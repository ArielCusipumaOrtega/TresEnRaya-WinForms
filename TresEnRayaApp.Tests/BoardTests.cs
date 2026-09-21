namespace TresEnRayaApp.Tests;

using TresEnRayaApp.Models;

public class BoardTests
{
    [Fact]
    public void Constructor_InitializesEmptyBoard()
    {
        var board = new Board();

        Assert.Equal(0, board.MovesCount);
        Assert.False(board.IsFull);
        Assert.Equal(9, board.GetAvailableMoves().Count());

        for (int i = 0; i < Board.BoardSize; i++)
        {
            Assert.Equal(Player.None, board[i]);
            Assert.True(board.IsCellEmpty(i));
        }
    }

    [Fact]
    public void MakeMove_ValidMove_ReturnsTrueAndSetsCell()
    {
        var board = new Board();

        bool result = board.MakeMove(4, Player.X);

        Assert.True(result);
        Assert.Equal(Player.X, board[4]);
        Assert.False(board.IsCellEmpty(4));
        Assert.Equal(1, board.MovesCount);
    }

    [Fact]
    public void MakeMove_OccupiedCell_ReturnsFalse()
    {
        var board = new Board();
        board.MakeMove(0, Player.X);

        bool result = board.MakeMove(0, Player.O);

        Assert.False(result);
        Assert.Equal(Player.X, board[0]);
        Assert.Equal(1, board.MovesCount);
    }

    [Fact]
    public void MakeMove_PlayerNone_ReturnsFalse()
    {
        var board = new Board();

        bool result = board.MakeMove(0, Player.None);

        Assert.False(result);
        Assert.Equal(0, board.MovesCount);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(9)]
    [InlineData(100)]
    public void Indexer_InvalidIndex_ThrowsArgumentOutOfRangeException(int invalidIndex)
    {
        var board = new Board();

        Assert.Throws<ArgumentOutOfRangeException>(() => board[invalidIndex]);
    }

    [Fact]
    public void Reset_ClearsAllCells()
    {
        var board = new Board();
        board.MakeMove(0, Player.X);
        board.MakeMove(1, Player.O);

        board.Reset();

        Assert.Equal(0, board.MovesCount);
        Assert.False(board.IsFull);
        for (int i = 0; i < Board.BoardSize; i++)
        {
            Assert.Equal(Player.None, board[i]);
        }
    }

    [Theory]
    [InlineData(0, 1, 2)] // Fila superior
    [InlineData(3, 4, 5)] // Fila central
    [InlineData(6, 7, 8)] // Fila inferior
    public void CheckWinner_HorizontalWins_DetectsCorrectWinner(int a, int b, int c)
    {
        var board = new Board();
        board.MakeMove(a, Player.X);
        board.MakeMove(b, Player.X);
        board.MakeMove(c, Player.X);

        bool hasWon = board.CheckWinner(out Player winner, out WinLine winLine);

        Assert.True(hasWon);
        Assert.Equal(Player.X, winner);
        Assert.Equal(new WinLine(a, b, c), winLine);
    }

    [Theory]
    [InlineData(0, 3, 6)] // Columna izquierda
    [InlineData(1, 4, 7)] // Columna central
    [InlineData(2, 5, 8)] // Columna derecha
    public void CheckWinner_VerticalWins_DetectsCorrectWinner(int a, int b, int c)
    {
        var board = new Board();
        board.MakeMove(a, Player.O);
        board.MakeMove(b, Player.O);
        board.MakeMove(c, Player.O);

        bool hasWon = board.CheckWinner(out Player winner, out WinLine winLine);

        Assert.True(hasWon);
        Assert.Equal(Player.O, winner);
        Assert.Equal(new WinLine(a, b, c), winLine);
    }

    [Theory]
    [InlineData(0, 4, 8)] // Diagonal principal
    [InlineData(2, 4, 6)] // Diagonal secundaria
    public void CheckWinner_DiagonalWins_DetectsCorrectWinner(int a, int b, int c)
    {
        var board = new Board();
        board.MakeMove(a, Player.X);
        board.MakeMove(b, Player.X);
        board.MakeMove(c, Player.X);

        bool hasWon = board.CheckWinner(out Player winner, out WinLine winLine);

        Assert.True(hasWon);
        Assert.Equal(Player.X, winner);
        Assert.Equal(new WinLine(a, b, c), winLine);
    }

    [Fact]
    public void CheckWinner_DrawBoard_ReturnsNoWinnerAndIsFull()
    {
        // Tablero en empate clásico:
        // X O X
        // X O O
        // O X X
        var board = new Board();
        board.MakeMove(0, Player.X);
        board.MakeMove(1, Player.O);
        board.MakeMove(2, Player.X);
        board.MakeMove(3, Player.X);
        board.MakeMove(4, Player.O);
        board.MakeMove(5, Player.O);
        board.MakeMove(6, Player.O);
        board.MakeMove(7, Player.X);
        board.MakeMove(8, Player.X);

        bool hasWon = board.CheckWinner(out Player winner, out _);

        Assert.False(hasWon);
        Assert.Equal(Player.None, winner);
        Assert.True(board.IsFull);
        Assert.Empty(board.GetAvailableMoves());
    }

    [Fact]
    public void Clone_CreatesIndependentCopy()
    {
        var original = new Board();
        original.MakeMove(0, Player.X);

        var clone = original.Clone();
        clone.MakeMove(1, Player.O);

        Assert.Equal(Player.X, original[0]);
        Assert.Equal(Player.None, original[1]);
        Assert.Equal(Player.O, clone[1]);
    }
}
