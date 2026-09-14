using System;
using System.Drawing;
using System.Windows.Forms;

namespace TresEnRayaApp
{
    public partial class MainForm : Form
    {
        // Variables de estado
        private bool turnoX = true;          // true = Turno de 'X', false = Turno de 'O'
        private int turnosJugados = 0;       // Contador de 0 a 9 movimientos
        private bool juegoTerminado = false; // Bloquea clics tras victoria o empate

        // Marcador histórico
        private int victoriasX = 0;
        private int victoriasO = 0;
        private int totalEmpates = 0;

        public MainForm()
        {
            InitializeComponent();
            ConfigurarInterfazInicial();
        }

        private void ConfigurarInterfazInicial()
        {
            IniciarNuevaPartida();
            ActualizarMarcador();
        }

        private void BotonTablero_click(object sender, EventArgs e)
        {
            if (juegoTerminado) return;

            Button? boton = sender as Button;
            if (boton == null || !string.IsNullOrEmpty(boton.Text)) return;

            // Marcar casilla según el turno actual
            if (turnoX)
            {
                boton.Text = "X";
                boton.ForeColor = Color.Black; // Color NEGRO para X
                lblTurno.Text = "Turno: Jugador O";
                lblTurno.ForeColor = Color.Red;
            }
            else
            {
                boton.Text = "O";
                boton.ForeColor = Color.Red;   // Color ROJO para O
                lblTurno.Text = "Turno: Jugador X";
                lblTurno.ForeColor = Color.Black;
            }

            turnosJugados++;

            // Validar victoria o empate
            VerificarEstadoJuego();

            // Alternar turno solo si no terminó la ronda
            if (!juegoTerminado)
            {
                turnoX = !turnoX;
            }
        }

        private void VerificarEstadoJuego()
        {
            bool hayGanador = false;
            string ganador = "";

            // 1. Filas
            if (ComprobarTrio(btn1, btn2, btn3)) hayGanador = true;
            else if (ComprobarTrio(btn4, btn5, btn6)) hayGanador = true;
            else if (ComprobarTrio(btn7, btn8, btn9)) hayGanador = true;
            // 2. Columnas
            else if (ComprobarTrio(btn1, btn4, btn7)) hayGanador = true;
            else if (ComprobarTrio(btn2, btn5, btn8)) hayGanador = true;
            else if (ComprobarTrio(btn3, btn6, btn9)) hayGanador = true;
            // 3. Diagonales
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

                MessageBox.Show($"¡Felicitaciones! El Jugador {ganador} es el ganador.",
                                "Fin de la Partida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Empate: 9 movimientos sin ganador
            if (turnosJugados == 9)
            {
                juegoTerminado = true;
                totalEmpates++;
                ActualizarMarcador();
                lblTurno.Text = "🤝 ¡Empate! Nadie ha ganado.";
                lblTurno.ForeColor = Color.FromArgb(108, 117, 125);

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
            Button[] botones = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
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