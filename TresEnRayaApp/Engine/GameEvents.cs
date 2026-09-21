namespace TresEnRayaApp.Engine;

using TresEnRayaApp.Models;

/// <summary>
/// Argumentos emitidos cuando se realiza una jugada válida en el tablero.
/// </summary>
public sealed record MoveMadeEventArgs(int CellIndex, Player Player);

/// <summary>
/// Argumentos emitidos cuando el turno cambia de jugador.
/// </summary>
public sealed record TurnChangedEventArgs(Player CurrentTurn, bool IsAiThinking);

/// <summary>
/// Argumentos emitidos cuando un jugador gana la partida.
/// </summary>
public sealed record GameWonEventArgs(Player Winner, WinLine WinningLine);

/// <summary>
/// Argumentos emitidos cuando el marcador numérico cambia.
/// </summary>
public sealed record ScoreChangedEventArgs(int WinsX, int WinsO, int Draws);
