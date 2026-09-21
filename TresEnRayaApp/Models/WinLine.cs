namespace TresEnRayaApp.Models;

/// <summary>
/// Representa la combinación ganadora de 3 casillas en el tablero.
/// </summary>
public readonly record struct WinLine(int IndexA, int IndexB, int IndexC)
{
    /// <summary>
    /// Devuelve los índices que conforman la línea ganadora.
    /// </summary>
    public IReadOnlyList<int> Indices => [IndexA, IndexB, IndexC];
}
