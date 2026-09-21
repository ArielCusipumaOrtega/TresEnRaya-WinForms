namespace TresEnRayaApp.Engine;

using TresEnRayaApp.Models;

/// <summary>
/// Contrato del motor de juego para la gestión de turnos, estado, reglas y puntuación.
/// </summary>
public interface ITicTacToeGame
{
    Board Board { get; }
    Player CurrentTurn { get; }
    GameState State { get; }
    GameMode Mode { get; }
    ScoreCard Score { get; }
    bool IsGameOver { get; }

    event EventHandler<MoveMadeEventArgs>? MoveMade;
    event EventHandler<TurnChangedEventArgs>? TurnChanged;
    event EventHandler<GameWonEventArgs>? GameWon;
    event EventHandler? GameDrawn;
    event EventHandler<ScoreChangedEventArgs>? ScoreChanged;
    event EventHandler? RoundStarted;

    bool MakeMove(int cellIndex);
    int ExecuteAiMove();
    void StartNewRound();
    void ResetScore();
    void SetGameMode(GameMode mode);
}
