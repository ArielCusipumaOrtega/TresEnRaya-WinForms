using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace TresEnRayaApp
{
    public partial class MainForm : Form
    {
        // Variables de estado
        private bool turnoX = true;          // true = Turno de 'X', false = Turno de 'O'
        private int turnosJugados = 0;       // Contador de movimientos
        private bool juegoTerminado = false; // Bloquea clics tras victoria o empate

        // Marcador histórico
        private int victoriasX = 0;
        private int victoriasO = 0;
        private int totalEmpates = 0;

        // Reproductores de sonido
        private SoundPlayer? reproductorFicha;
        private SoundPlayer? reproductorGanar;
        private SoundPlayer? reproductorEmpate;

        public MainForm()
        {
            InitializeComponent();
            InicializarSonidos();
            ConfigurarInterfazInicial();
        }

        private void InicializarSonidos()
        {
            try
            {
                string carpetaMedia = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Media");

                string rutaFicha = Path.Combine(carpetaMedia, "chord.wav");
                string rutaGanar = Path.Combine(carpetaMedia, "tada.wav");
                string rutaEmpate = Path.Combine(carpetaMedia, "ding.wav");

                if (File.Exists(rutaFicha)) reproductorFicha = new SoundPlayer(rutaFicha);
                if (File.Exists(rutaGanar)) reproductorGanar = new SoundPlayer(rutaGanar);
                if (File.Exists(rutaEmpate)) reproductorEmpate = new SoundPlayer(rutaEmpate);
            }
            catch
            {
                // Previene caídas si el sistema no posee acceso al directorio multimedia
            }
        }

        private void ReproducirSonido(SoundPlayer? reproductor)
        {
            try
            {
                reproductor?.Play();
            }
            catch
            {
                // Captura defensiva si el dispositivo de audio está ocupado
            }
        }

        private void ConfigurarInterfazInicial()
        {
            IniciarNuevaPartida();
            ActualizarMarcador();
        }

        private void BotonTablero_click(object sender, EventArgs e)
        {
            if (juegoTerminado || (rbContraIA.Checked && !turnoX)) return;

            Button? boton = sender as Button;
            if (boton == null || !string.IsNullOrEmpty(boton.Text)) return;

            if (turnoX)
            {
                boton.Text = "X";
                boton.ForeColor = Color.Black;
                ReproducirSonido(reproductorFicha); // Sonido al colocar ficha

                lblTurno.Text = rbContraIA.Checked ? "Pensando IA..." : "Turno: Jugador O";
                lblTurno.ForeColor = Color.Red;

                turnosJugados++;
                VerificarEstadoJuego();

                if (!juegoTerminado)
                {
                    turnoX = false;
                    if (rbContraIA.Checked)
                    {
                        EjecutarMovimientoIA();
                    }
                }
            }
            else
            {
                boton.Text = "O";
                boton.ForeColor = Color.Red;
                ReproducirSonido(reproductorFicha); // Sonido al colocar ficha

                lblTurno.Text = "Turno: Jugador X";
                lblTurno.ForeColor = Color.Black;

                turnosJugados++;
                VerificarEstadoJuego();

                if (!juegoTerminado)
                {
                    turnoX = true;
                }
            }
        }

        private void VerificarEstadoJuego()
        {
            bool hayGanador = false;
            string ganador = "";

            if (ComprobarTrio(btn1, btn2, btn3)) hayGanador = true;
            else if (ComprobarTrio(btn4, btn5, btn6)) hayGanador = true;
            else if (ComprobarTrio(btn7, btn8, btn9)) hayGanador = true;
            else if (ComprobarTrio(btn1, btn4, btn7)) hayGanador = true;
            else if (ComprobarTrio(btn2, btn5, btn8)) hayGanador = true;
            else if (ComprobarTrio(btn3, btn6, btn9)) hayGanador = true;
            else if (ComprobarTrio(btn1, btn5, btn9)) hayGanador = true;
            else if (ComprobarTrio(btn3, btn5, btn7)) hayGanador = true;

            if (hayGanador)
            {
                juegoTerminado = true;
                ganador = turnoX ? "X" : "O";

                if (turnoX) victoriasX++;
                else victoriasO++;

                ActualizarMarcador();
                lblTurno.Text = $"🎉 ¡El Jugador {ganador} ha ganado!";
                lblTurno.ForeColor = Color.FromArgb(46, 125, 50);

                ReproducirSonido(reproductorGanar); // Sonido festivo al ganar

                MessageBox.Show($"¡Felicitaciones! El Jugador {ganador} es el ganador.",
                                "Fin de la Partida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (turnosJugados == 9)
            {
                juegoTerminado = true;
                totalEmpates++;
                ActualizarMarcador();
                lblTurno.Text = "🤝 ¡Empate! Nadie ha ganado.";
                lblTurno.ForeColor = Color.FromArgb(108, 117, 125);

                ReproducirSonido(reproductorEmpate); // Sonido neutral al empatar

                MessageBox.Show("¡La partida ha terminado en empate!",
                                "Empate", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ComprobarTrio(Button b1, Button b2, Button b3)
        {
            if (!string.IsNullOrEmpty(b1.Text) && b1.Text == b2.Text && b2.Text == b3.Text)
            {
                Color verdeGanador = Color.FromArgb(200, 245, 200);
                b1.BackColor = verdeGanador;
                b2.BackColor = verdeGanador;
                b3.BackColor = verdeGanador;
                return true;
            }
            return false;
        }

        private void IniciarNuevaPartida()
        {
            Button[] botones = ObtenerBotonesTablero();
            foreach (Button b in botones)
            {
                b.Text = "";
                b.Enabled = true;
                b.BackColor = Color.White;
            }

            turnoX = true;
            turnosJugados = 0;
            juegoTerminado = false;
            lblTurno.Text = "Turno: Jugador X";
            lblTurno.ForeColor = Color.Black;
        }

        private void ActualizarMarcador()
        {
            lblScoreX.Text = $"Jugador X: {victoriasX}";
            lblScoreO.Text = $"Jugador O: {victoriasO}";
            lblEmpates.Text = $"Empates: {totalEmpates}";
        }

        // LÓGICA MINIMAX

        private Button[] ObtenerBotonesTablero()
        {
            return new Button[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
        }

        private void EjecutarMovimientoIA()
        {
            if (juegoTerminado) return;

            int mejorIndice = ObtenerMejorMovimiento();
            if (mejorIndice == -1) return;

            Button botonElegido = ObtenerBotonesTablero()[mejorIndice];
            botonElegido.Text = "O";
            botonElegido.ForeColor = Color.Red;
            ReproducirSonido(reproductorFicha); // Sonido al colocar la ficha la máquina

            lblTurno.Text = "Turno: Jugador X";
            lblTurno.ForeColor = Color.Black;

            turnosJugados++;
            VerificarEstadoJuego();

            if (!juegoTerminado)
            {
                turnoX = true;
            }
        }

        private int ObtenerMejorMovimiento()
        {
            Button[] botones = ObtenerBotonesTablero();
            string[] tableroVirtual = new string[9];
            for (int i = 0; i < 9; i++)
            {
                tableroVirtual[i] = botones[i].Text;
            }

            int mejorPuntaje = int.MinValue;
            int mejorIndice = -1;

            for (int i = 0; i < 9; i++)
            {
                if (string.IsNullOrEmpty(tableroVirtual[i]))
                {
                    tableroVirtual[i] = "O";
                    int puntaje = Minimax(tableroVirtual, 0, false);
                    tableroVirtual[i] = "";

                    if (puntaje > mejorPuntaje)
                    {
                        mejorPuntaje = puntaje;
                        mejorIndice = i;
                    }
                }
            }

            return mejorIndice;
        }

        private int Minimax(string[] tablero, int profundidad, bool esMaximizador)
        {
            int evaluacion = EvaluarEstadoVirtual(tablero);

            if (evaluacion == 10) return evaluacion - profundidad;
            if (evaluacion == -10) return evaluacion + profundidad;
            if (Array.TrueForAll(tablero, celda => !string.IsNullOrEmpty(celda))) return 0;

            if (esMaximizador)
            {
                int maxPuntaje = int.MinValue;
                for (int i = 0; i < 9; i++)
                {
                    if (string.IsNullOrEmpty(tablero[i]))
                    {
                        tablero[i] = "O";
                        maxPuntaje = Math.Max(maxPuntaje, Minimax(tablero, profundidad + 1, false));
                        tablero[i] = "";
                    }
                }
                return maxPuntaje;
            }
            else
            {
                int minPuntaje = int.MaxValue;
                for (int i = 0; i < 9; i++)
                {
                    if (string.IsNullOrEmpty(tablero[i]))
                    {
                        tablero[i] = "X";
                        minPuntaje = Math.Min(minPuntaje, Minimax(tablero, profundidad + 1, true));
                        tablero[i] = "";
                    }
                }
                return minPuntaje;
            }
        }

        private int EvaluarEstadoVirtual(string[] t)
        {
            int[][] lineas = new int[][]
            {
                new int[] {0, 1, 2}, new int[] {3, 4, 5}, new int[] {6, 7, 8},
                new int[] {0, 3, 6}, new int[] {1, 4, 7}, new int[] {2, 5, 8},
                new int[] {0, 4, 8}, new int[] {2, 4, 6}
            };

            foreach (var l in lineas)
            {
                if (!string.IsNullOrEmpty(t[l[0]]) && t[l[0]] == t[l[1]] && t[l[1]] == t[l[2]])
                {
                    return t[l[0]] == "O" ? 10 : -10;
                }
            }

            return 0;
        }

        // EVENTOS DE LA INTERFAZ

        private void ModoJuego_CheckedChanged(object sender, EventArgs e)
        {
            IniciarNuevaPartida();
        }

        private void btnNuevaPartida_Click(object sender, EventArgs e)
        {
            IniciarNuevaPartida();
        }

        private void btnReiniciarMarcador_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro de que deseas reiniciar todos los puntajes a cero?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                victoriasX = 0;
                victoriasO = 0;
                totalEmpates = 0;
                ActualizarMarcador();
                IniciarNuevaPartida();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}