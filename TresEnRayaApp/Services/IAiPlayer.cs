namespace TresEnRayaApp.Services;

using TresEnRayaApp.Models;

/// <summary>
/// Contrato para proveedores de inteligencia artificial en el juego.
/// </summary>
public interface IAiPlayer
{
    /// <summary>
    /// Calcula el índice de la casilla óptima (0-8) para el jugador de IA dado el estado del tablero.
    /// </summary>
    /// <param name="board">Tablero actual.</param>
    /// <param name="aiPlayer">Jugador que representa a la IA.</param>
    /// <returns>El índice de la mejor casilla disponible, o -1 si no existen movimientos válidos.</returns>
    int CalculateBestMove(Board board, Player aiPlayer);
}
