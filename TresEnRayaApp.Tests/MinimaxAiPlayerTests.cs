namespace TresEnRayaApp.Tests;

using TresEnRayaApp.Models;
using TresEnRayaApp.Services;

public class MinimaxAiPlayerTests
{
    private readonly MinimaxAiPlayer _ai = new();

    [Fact]
    public void CalculateBestMove_ThrowsOnNullBoard()
    {
        Assert.Throws<ArgumentNullException>(() => _ai.CalculateBestMove(null!, Player.O));
    }

    [Fact]
    public void CalculateBestMove_ThrowsOnPlayerNone()
    {
        var board = new Board();
        Assert.Throws<ArgumentException>(() => _ai.CalculateBestMove(board, Player.None));
    }

    [Fact]
    public void CalculateBestMove_TakesImmediateWinningMove()
    {
        // O O .
        // X X .
        // . . .
        // Si es el turno de O, debe jugar en la casilla 2 para ganar de inmediato
        var board = new Board();
        board.MakeMove(0, Player.O);
        board.MakeMove(3, Player.X);
        board.MakeMove(1, Player.O);
        board.MakeMove(4, Player.X);

        int bestMove = _ai.CalculateBestMove(board, Player.O);

        Assert.Equal(2, bestMove);
    }

    [Fact]
    public void CalculateBestMove_BlocksOpponentWinningMove()
    {
        // X X .
        // O . .
        // . . .
        // X está a punto de ganar en la casilla 2. La IA (O) debe bloquear en 2.
        var board = new Board();
        board.MakeMove(0, Player.X);
        board.MakeMove(3, Player.O);
        board.MakeMove(1, Player.X);

        int bestMove = _ai.CalculateBestMove(board, Player.O);

        Assert.Equal(2, bestMove);
    }

    [Fact]
    public void CalculateBestMove_BlocksDiagonalFork()
    {
        // X . .
        // . O .
        // . . X
        // El jugador X intenta doble amenaza por las esquinas. La IA (O) debe jugar en los bordes para evitar la trampa.
        var board = new Board();
        board.MakeMove(0, Player.X);
        board.MakeMove(4, Player.O);
        board.MakeMove(8, Player.X);

        int bestMove = _ai.CalculateBestMove(board, Player.O);

        // Los movimientos que evitan bifurcación son las aristas (1, 3, 5, 7)
        Assert.Contains(bestMove, new[] { 1, 3, 5, 7 });
    }

    [Fact]
    public void AiVsAi_AlwaysResultsInDraw()
    {
        var board = new Board();
        Player current = Player.X;

        while (!board.IsFull && !board.CheckWinner(out _, out _))
        {
            int move = _ai.CalculateBestMove(board, current);
            Assert.True(board.MakeMove(move, current));
            current = current.GetOpponent();
        }

        bool hasWon = board.CheckWinner(out Player winner, out _);

        Assert.False(hasWon);
        Assert.Equal(Player.None, winner);
        Assert.True(board.IsFull);
    }

    [Fact]
    public void AiVsRandomPlayer_AiNeverLoses()
    {
        var random = new Random(42);

        // Simulamos 50 partidas donde el Humano (X) hace movimientos aleatorios y la IA (O) juega óptimamente
        for (int i = 0; i < 50; i++)
        {
            var board = new Board();
            Player current = Player.X;

            while (!board.IsFull && !board.CheckWinner(out _, out _))
            {
                if (current == Player.X)
                {
                    var available = board.GetAvailableMoves().ToList();
                    int randomMove = available[random.Next(available.Count)];
                    board.MakeMove(randomMove, Player.X);
                }
                else
                {
                    int aiMove = _ai.CalculateBestMove(board, Player.O);
                    board.MakeMove(aiMove, Player.O);
                }

                current = current.GetOpponent();
            }

            bool hasWon = board.CheckWinner(out Player winner, out _);

            // La IA nunca debe perder (el ganador solo puede ser O o None/Empate)
            Assert.NotEqual(Player.X, winner);
        }
    }
}
