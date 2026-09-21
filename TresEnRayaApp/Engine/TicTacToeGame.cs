namespace TresEnRayaApp.Engine;

using TresEnRayaApp.Models;
using TresEnRayaApp.Services;

/// <summary>
/// Motor central del juego Tres en Raya que coordina reglas, turnos, IA y puntuaciones.
/// </summary>
public sealed class TicTacToeGame : ITicTacToeGame
{
    private readonly IAiPlayer _aiPlayer;

    public Board Board { get; } = new();
    public ScoreCard Score { get; } = new();
    public Player CurrentTurn { get; private set; } = Player.X;
    public GameState State { get; private set; } = GameState.InProgress;
    public GameMode Mode { get; private set; }

    public bool IsGameOver => State != GameState.InProgress;

    public event EventHandler<MoveMadeEventArgs>? MoveMade;
    public event EventHandler<TurnChangedEventArgs>? TurnChanged;
    public event EventHandler<GameWonEventArgs>? GameWon;
    public event EventHandler? GameDrawn;
    public event EventHandler<ScoreChangedEventArgs>? ScoreChanged;
    public event EventHandler? RoundStarted;

    public TicTacToeGame(IAiPlayer? aiPlayer = null, GameMode initialMode = GameMode.PlayerVsAi)
    {
        _aiPlayer = aiPlayer ?? new MinimaxAiPlayer();
        Mode = initialMode;
    }

    public bool MakeMove(int cellIndex)
    {
        if (IsGameOver) return false;

        Player movingPlayer = CurrentTurn;
        if (!Board.MakeMove(cellIndex, movingPlayer))
        {
            return false;
        }

        MoveMade?.Invoke(this, new MoveMadeEventArgs(cellIndex, movingPlayer));

        if (ProcessGameTermination())
        {
            return true;
        }

        CurrentTurn = CurrentTurn.GetOpponent();
        bool isAiThinking = Mode == GameMode.PlayerVsAi && CurrentTurn == Player.O;
        TurnChanged?.Invoke(this, new TurnChangedEventArgs(CurrentTurn, isAiThinking));

        return true;
    }

    public int ExecuteAiMove()
    {
        if (IsGameOver || Mode != GameMode.PlayerVsAi || CurrentTurn != Player.O)
        {
            return -1;
        }

        int bestMove = _aiPlayer.CalculateBestMove(Board, Player.O);
        if (bestMove < 0)
        {
            return -1;
        }

        Board.MakeMove(bestMove, Player.O);
        MoveMade?.Invoke(this, new MoveMadeEventArgs(bestMove, Player.O));

        if (ProcessGameTermination())
        {
            return bestMove;
        }

        CurrentTurn = Player.X;
        TurnChanged?.Invoke(this, new TurnChangedEventArgs(Player.X, IsAiThinking: false));

        return bestMove;
    }

    public void StartNewRound()
    {
        Board.Reset();
        CurrentTurn = Player.X;
        State = GameState.InProgress;

        RoundStarted?.Invoke(this, EventArgs.Empty);
        TurnChanged?.Invoke(this, new TurnChangedEventArgs(Player.X, IsAiThinking: false));
    }

    public void ResetScore()
    {
        Score.Reset();
        ScoreChanged?.Invoke(this, new ScoreChangedEventArgs(0, 0, 0));
        StartNewRound();
    }

    public void SetGameMode(GameMode mode)
    {
        Mode = mode;
        StartNewRound();
    }

    private bool ProcessGameTermination()
    {
        if (Board.CheckWinner(out Player winner, out WinLine winningLine))
        {
            State = GameState.Won;
            Score.RecordWin(winner);
            GameWon?.Invoke(this, new GameWonEventArgs(winner, winningLine));
            ScoreChanged?.Invoke(this, new ScoreChangedEventArgs(Score.WinsX, Score.WinsO, Score.Draws));
            return true;
        }

        if (Board.IsFull)
        {
            State = GameState.Draw;
            Score.RecordDraw();
            GameDrawn?.Invoke(this, EventArgs.Empty);
            ScoreChanged?.Invoke(this, new ScoreChangedEventArgs(Score.WinsX, Score.WinsO, Score.Draws));
            return true;
        }

        return false;
    }
}
