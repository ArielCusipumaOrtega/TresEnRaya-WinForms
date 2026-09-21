namespace TresEnRayaApp.Models;

/// <summary>
/// Representa el tablero de juego de 3x3 (9 casillas) y sus reglas de adyacencia y victoria.
/// </summary>
public sealed class Board
{
    public const int BoardSize = 9;
    private readonly Player[] _cells = new Player[BoardSize];

    /// <summary>
    /// Las 8 combinaciones posibles de victoria (3 horizontales, 3 verticales y 2 diagonales).
    /// </summary>
    public static readonly IReadOnlyList<WinLine> WinningCombinations =
    [
        new(0, 1, 2), // Fila superior
        new(3, 4, 5), // Fila central
        new(6, 7, 8), // Fila inferior
        new(0, 3, 6), // Columna izquierda
        new(1, 4, 7), // Columna central
        new(2, 5, 8), // Columna derecha
        new(0, 4, 8), // Diagonal principal
        new(2, 4, 6)  // Diagonal secundaria
    ];

    public Board()
    {
    }

    private Board(Player[] sourceCells)
    {
        Array.Copy(sourceCells, _cells, BoardSize);
    }

    /// <summary>
    /// Obtiene el estado del jugador en una celda determinada (0-8).
    /// </summary>
    public Player this[int index]
    {
        get
        {
            ValidateIndex(index);
            return _cells[index];
        }
    }

    /// <summary>
    /// Comprueba si una casilla específica está desocupada.
    /// </summary>
    public bool IsCellEmpty(int index)
    {
        ValidateIndex(index);
        return _cells[index] == Player.None;
    }

    /// <summary>
    /// Aplica una jugada si la celda está disponible y el jugador es válido.
    /// </summary>
    public bool MakeMove(int index, Player player)
    {
        if (player == Player.None || !IsCellEmpty(index))
        {
            return false;
        }

        _cells[index] = player;
        return true;
    }

    /// <summary>
    /// Restablece una casilla específica a vacía (útil para algoritmos de búsqueda como Minimax).
    /// </summary>
    public void ClearCell(int index)
    {
        ValidateIndex(index);
        _cells[index] = Player.None;
    }

    /// <summary>
    /// Reinicia todas las casillas del tablero a su estado vacío.
    /// </summary>
    public void Reset()
    {
        Array.Fill(_cells, Player.None);
    }

    /// <summary>
    /// Indica si el tablero no posee casillas libres.
    /// </summary>
    public bool IsFull => _cells.All(cell => cell != Player.None);

    /// <summary>
    /// Devuelve el total de movimientos realizados en la partida actual.
    /// </summary>
    public int MovesCount => _cells.Count(cell => cell != Player.None);

    /// <summary>
    /// Retorna los índices de todas las casillas que aún permanecen vacías.
    /// </summary>
    public IEnumerable<int> GetAvailableMoves()
    {
        for (int i = 0; i < BoardSize; i++)
        {
            if (_cells[i] == Player.None)
            {
                yield return i;
            }
        }
    }

    /// <summary>
    /// Verifica si existe un ganador según las líneas de victoria.
    /// </summary>
    public bool CheckWinner(out Player winner, out WinLine winningLine)
    {
        foreach (var line in WinningCombinations)
        {
            Player candidate = _cells[line.IndexA];
            if (candidate != Player.None &&
                candidate == _cells[line.IndexB] &&
                candidate == _cells[line.IndexC])
            {
                winner = candidate;
                winningLine = line;
                return true;
            }
        }

        winner = Player.None;
        winningLine = default;
        return false;
    }

    /// <summary>
    /// Genera una copia independiente del tablero.
    /// </summary>
    public Board Clone() => new(_cells);

    private static void ValidateIndex(int index)
    {
        if (index is < 0 or >= BoardSize)
        {
            throw new ArgumentOutOfRangeException(nameof(index), $"El índice {index} está fuera del rango [0, {BoardSize - 1}].");
        }
    }
}
