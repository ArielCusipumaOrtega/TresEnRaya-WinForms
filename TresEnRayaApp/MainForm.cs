namespace TresEnRayaApp;

using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using TresEnRayaApp.Engine;
using TresEnRayaApp.Models;
using TresEnRayaApp.Services;

public partial class MainForm : Form
{
    // Paleta de colores de diseño moderno (Midnight Slate & Vibrant Accents)
    private static readonly Color ColorCeldaNormal = Color.FromArgb(30, 41, 59);      // Slate 800
    private static readonly Color ColorCeldaHover = Color.FromArgb(51, 65, 85);       // Slate 700
    private static readonly Color ColorBordeNormal = Color.FromArgb(51, 65, 85);      // Slate 700
    private static readonly Color ColorBordeHover = Color.FromArgb(100, 116, 139);    // Slate 500

    private static readonly Color ColorJugadorX = Color.FromArgb(56, 189, 248);       // Electric Sky Cyan
    private static readonly Color ColorJugadorO = Color.FromArgb(244, 63, 94);        // Vibrant Coral Rose
    private static readonly Color ColorPensandoIA = Color.FromArgb(251, 191, 36);     // Amber Warning

    private static readonly Color ColorGanadorFondo = Color.FromArgb(6, 78, 59);       // Emerald 900
    private static readonly Color ColorGanadorTexto = Color.FromArgb(52, 211, 153);    // Emerald 400
    private static readonly Color ColorGanadorBorde = Color.FromArgb(16, 185, 129);    // Emerald 500

    private static readonly Color ColorTextoEmpate = Color.FromArgb(203, 213, 225);    // Slate 300

    private readonly ITicTacToeGame _game;
    private readonly ISoundService _soundService;
    private readonly Button[] _boardButtons;

    public MainForm() : this(new TicTacToeGame(), new SoundService())
    {
    }

    public MainForm(ITicTacToeGame game, ISoundService soundService)
    {
        ArgumentNullException.ThrowIfNull(game);
        ArgumentNullException.ThrowIfNull(soundService);

        _game = game;
        _soundService = soundService;

        InitializeComponent();

        _boardButtons = [btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9];

        ConfigurarEfectosVisualesInteractivos();
        SuscribirEventosDelJuego();
        FormClosed += (_, _) => _soundService.Dispose();

        InicializarEstadoVisual();
    }

    private void ConfigurarEfectosVisualesInteractivos()
    {
        // Hover interactivo para las casillas del tablero
        foreach (Button btn in _boardButtons)
        {
            btn.MouseEnter += (s, e) =>
            {
                if (string.IsNullOrEmpty(btn.Text) && !_game.IsGameOver && btn.Enabled)
                {
                    btn.BackColor = ColorCeldaHover;
                    btn.FlatAppearance.BorderColor = ColorBordeHover;
                }
            };

            btn.MouseLeave += (s, e) =>
            {
                if (string.IsNullOrEmpty(btn.Text) && !_game.IsGameOver)
                {
                    btn.BackColor = ColorCeldaNormal;
                    btn.FlatAppearance.BorderColor = ColorBordeNormal;
                }
            };
        }

        // Efectos de hover sobre los botones de acción
        btnNuevaPartida.MouseEnter += (_, _) => btnNuevaPartida.BackColor = Color.FromArgb(3, 105, 161);
        btnNuevaPartida.MouseLeave += (_, _) => btnNuevaPartida.BackColor = Color.FromArgb(2, 132, 199);

        btnReiniciarMarcador.MouseEnter += (_, _) => btnReiniciarMarcador.BackColor = Color.FromArgb(71, 85, 105);
        btnReiniciarMarcador.MouseLeave += (_, _) => btnReiniciarMarcador.BackColor = Color.FromArgb(51, 65, 85);

        btnSalir.MouseEnter += (_, _) => btnSalir.BackColor = Color.FromArgb(185, 28, 28);
        btnSalir.MouseLeave += (_, _) => btnSalir.BackColor = Color.FromArgb(153, 27, 27);
    }

    private void SuscribirEventosDelJuego()
    {
        _game.MoveMade += OnMoveMade;
        _game.TurnChanged += OnTurnChanged;
        _game.GameWon += OnGameWon;
        _game.GameDrawn += OnGameDrawn;
        _game.ScoreChanged += OnScoreChanged;
        _game.RoundStarted += OnRoundStarted;
    }

    private void InicializarEstadoVisual()
    {
        _game.StartNewRound();
        ActualizarVistaMarcador(_game.Score.WinsX, _game.Score.WinsO, _game.Score.Draws);
    }

    // GESTIÓN DE EVENTOS DEL MOTOR DE JUEGO

    private void OnMoveMade(object? sender, MoveMadeEventArgs e)
    {
        Button btn = _boardButtons[e.CellIndex];
        btn.Text = e.Player.ToSymbol();
        btn.ForeColor = e.Player == Player.X ? ColorJugadorX : ColorJugadorO;
        btn.BackColor = ColorCeldaNormal;
        btn.FlatAppearance.BorderColor = ColorBordeNormal;
        _soundService.PlayMove();
    }

    private void OnTurnChanged(object? sender, TurnChangedEventArgs e)
    {
        if (e.IsAiThinking)
        {
            lblTurno.Text = "🤖  Pensando IA...";
            lblTurno.ForeColor = ColorPensandoIA;
        }
        else
        {
            string simbolo = e.CurrentTurn.ToSymbol();
            string icono = e.CurrentTurn == Player.X ? "⚔️" : "🛡️";
            lblTurno.Text = $"{icono}  Turno: Jugador {simbolo}";
            lblTurno.ForeColor = e.CurrentTurn == Player.X ? ColorJugadorX : ColorJugadorO;
        }
    }

    private void OnGameWon(object? sender, GameWonEventArgs e)
    {
        foreach (int index in e.WinningLine.Indices)
        {
            Button btn = _boardButtons[index];
            btn.BackColor = ColorGanadorFondo;
            btn.ForeColor = ColorGanadorTexto;
            btn.FlatAppearance.BorderColor = ColorGanadorBorde;
        }

        string simboloGanador = e.Winner.ToSymbol();
        lblTurno.Text = $"🎉  ¡El Jugador {simboloGanador} ha ganado!";
        lblTurno.ForeColor = ColorGanadorTexto;

        _soundService.PlayWin();

        MessageBox.Show(
            $"¡Felicitaciones! El Jugador {simboloGanador} es el ganador.",
            "Fin de la Partida",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private void OnGameDrawn(object? sender, EventArgs e)
    {
        lblTurno.Text = "🤝  ¡Empate! Nadie ha ganado.";
        lblTurno.ForeColor = ColorTextoEmpate;

        _soundService.PlayDraw();

        MessageBox.Show(
            "¡La partida ha terminado en empate!",
            "Empate",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private void OnScoreChanged(object? sender, ScoreChangedEventArgs e)
    {
        ActualizarVistaMarcador(e.WinsX, e.WinsO, e.Draws);
    }

    private void OnRoundStarted(object? sender, EventArgs e)
    {
        foreach (Button btn in _boardButtons)
        {
            btn.Text = string.Empty;
            btn.Enabled = true;
            btn.BackColor = ColorCeldaNormal;
            btn.FlatAppearance.BorderColor = ColorBordeNormal;
        }
    }

    private void ActualizarVistaMarcador(int winsX, int winsO, int draws)
    {
        lblScoreX.Text = $"Jugador X: {winsX}";
        lblScoreO.Text = $"Jugador O: {winsO}";
        lblEmpates.Text = $"Empates: {draws}";
    }

    // INTERACCIÓN DEL USUARIO CON LA INTERFAZ

    private async void BotonTablero_click(object? sender, EventArgs e)
    {
        if (sender is not Button { Tag: string tagStr } || !int.TryParse(tagStr, out int cellIndex))
        {
            return;
        }

        if (!_game.MakeMove(cellIndex))
        {
            return;
        }

        // Si el modo es contra la IA y la partida sigue en curso, la IA realiza su turno
        if (_game.Mode == GameMode.PlayerVsAi && !_game.IsGameOver && _game.CurrentTurn == Player.O)
        {
            HabilitarTablero(false);
            await Task.Delay(200); // Pausa reactiva que mejora la experiencia de usuario
            _game.ExecuteAiMove();
            HabilitarTablero(true);
        }
    }

    private void HabilitarTablero(bool habilitar)
    {
        foreach (Button btn in _boardButtons)
        {
            if (string.IsNullOrEmpty(btn.Text))
            {
                btn.Enabled = habilitar;
            }
        }
    }

    private void ModoJuego_CheckedChanged(object? sender, EventArgs e)
    {
        if (sender is RadioButton { Checked: true } rb)
        {
            GameMode nuevoModo = rb == rbContraIA ? GameMode.PlayerVsAi : GameMode.PlayerVsPlayer;
            _game.SetGameMode(nuevoModo);
        }
    }

    private void btnNuevaPartida_Click(object? sender, EventArgs e)
    {
        _game.StartNewRound();
    }

    private void btnReiniciarMarcador_Click(object? sender, EventArgs e)
    {
        DialogResult respuesta = MessageBox.Show(
            "¿Estás seguro de que deseas reiniciar todos los puntajes a cero?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (respuesta == DialogResult.Yes)
        {
            _game.ResetScore();
        }
    }

    private void btnSalir_Click(object? sender, EventArgs e)
    {
        Application.Exit();
    }
}