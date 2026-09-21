namespace TresEnRayaApp.Models;

/// <summary>
/// Representa el estado actual de la partida.
/// </summary>
public enum GameState
{
    /// <summary>
    /// La partida está en progreso y se aceptan jugadas.
    /// </summary>
    InProgress,

    /// <summary>
    /// La partida finalizó con una victoria.
    /// </summary>
    Won,

    /// <summary>
    /// La partida finalizó en empate sin casillas disponibles.
    /// </summary>
    Draw
}
