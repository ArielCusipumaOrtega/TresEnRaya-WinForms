namespace TresEnRayaApp.Models;

/// <summary>
/// Define los modos de juego disponibles.
/// </summary>
public enum GameMode
{
    /// <summary>
    /// Partida entre un humano y la Inteligencia Artificial (Minimax).
    /// </summary>
    PlayerVsAi,

    /// <summary>
    /// Partida local entre dos personas por turnos.
    /// </summary>
    PlayerVsPlayer
}
