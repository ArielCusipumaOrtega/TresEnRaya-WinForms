namespace TresEnRayaApp.Services;

using TresEnRayaApp.Models;

/// <summary>
/// Implementación de Inteligencia Artificial invencible basada en el algoritmo Minimax con ponderación de profundidad.
/// </summary>
public sealed class MinimaxAiPlayer : IAiPlayer
{
    private const int WinScore = 10;
    private const int LossScore = -10;
    private const int TieScore = 0;

    public int CalculateBestMove(Board board, Player aiPlayer)
    {
        ArgumentNullException.ThrowIfNull(board);

        if (aiPlayer == Player.None)
        {
            throw new ArgumentException("La IA debe ser un jugador válido (X u O).", nameof(aiPlayer));
        }

        Player humanPlayer = aiPlayer.GetOpponent();
        int bestScore = int.MinValue;
        int bestMove = -1;

        foreach (int move in board.GetAvailableMoves())
        {
            board.MakeMove(move, aiPlayer);
            int score = Minimax(board, depth: 0, isMaximizing: false, aiPlayer, humanPlayer);
            board.ClearCell(move);

            if (score > bestScore)
            {
                bestScore = score;
                bestMove = move;
            }
        }

        return bestMove;
    }

    private static int Minimax(Board board, int depth, bool isMaximizing, Player aiPlayer, Player humanPlayer)
    {
        if (board.CheckWinner(out Player winner, out _))
        {
            // Ponderación por profundidad: prioriza victorias rápidas y retrasa posibles derrotas
            return winner == aiPlayer ? (WinScore - depth) : (LossScore + depth);
        }

        if (board.IsFull)
        {
            return TieScore;
        }

        if (isMaximizing)
        {
            int maxScore = int.MinValue;
            foreach (int move in board.GetAvailableMoves())
            {
                board.MakeMove(move, aiPlayer);
                int score = Minimax(board, depth + 1, isMaximizing: false, aiPlayer, humanPlayer);
                board.ClearCell(move);
                maxScore = Math.Max(maxScore, score);
            }
            return maxScore;
        }
        else
        {
            int minScore = int.MaxValue;
            foreach (int move in board.GetAvailableMoves())
            {
                board.MakeMove(move, humanPlayer);
                int score = Minimax(board, depth + 1, isMaximizing: true, aiPlayer, humanPlayer);
                board.ClearCell(move);
                minScore = Math.Min(minScore, score);
            }
            return minScore;
        }
    }
}
