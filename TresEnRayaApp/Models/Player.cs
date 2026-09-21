namespace TresEnRayaApp.Models;

/// <summary>
/// Representa a los jugadores en el juego Tres en Raya.
/// </summary>
public enum Player
{
    None = 0,
    X = 1,
    O = 2
}

/// <summary>
/// Métodos de extensión para simplificar operaciones comunes sobre <see cref="Player"/>.
/// </summary>
public static class PlayerExtensions
{
    /// <summary>
    /// Devuelve el oponente correspondiente a un jugador dado.
    /// </summary>
    public static Player GetOpponent(this Player player) => player switch
    {
        Player.X => Player.O,
        Player.O => Player.X,
        _ => Player.None
    };

    /// <summary>
    /// Obtiene la representación en texto o símbolo del jugador.
    /// </summary>
    public static string ToSymbol(this Player player) => player switch
    {
        Player.X => "X",
        Player.O => "O",
        _ => string.Empty
    };
}
