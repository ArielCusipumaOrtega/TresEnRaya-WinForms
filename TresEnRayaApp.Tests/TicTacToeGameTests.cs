namespace TresEnRayaApp.Tests;

using TresEnRayaApp.Engine;
using TresEnRayaApp.Models;

public class TicTacToeGameTests
{
    [Fact]
    public void Constructor_InitializesDefaultState()
    {
        var game = new TicTacToeGame();

        Assert.Equal(Player.X, game.CurrentTurn);
        Assert.Equal(GameState.InProgress, game.State);
        Assert.False(game.IsGameOver);
        Assert.Equal(GameMode.PlayerVsAi, game.Mode);
        Assert.Equal(0, game.Score.WinsX);
        Assert.Equal(0, game.Score.WinsO);
        Assert.Equal(0, game.Score.Draws);
    }

    [Fact]
    public void MakeMove_PlayerVsPlayer_AlternatesTurnsAndFiresEvents()
    {
        var game = new TicTacToeGame(initialMode: GameMode.PlayerVsPlayer);
        MoveMadeEventArgs? lastMove = null;
        TurnChangedEventArgs? lastTurn = null;

        game.MoveMade += (_, e) => lastMove = e;
        game.TurnChanged += (_, e) => lastTurn = e;

        bool moveResult = game.MakeMove(0);

        Assert.True(moveResult);
        Assert.NotNull(lastMove);
        Assert.Equal(0, lastMove.CellIndex);
        Assert.Equal(Player.X, lastMove.Player);
        Assert.NotNull(lastTurn);
        Assert.Equal(Player.O, lastTurn.CurrentTurn);
        Assert.False(lastTurn.IsAiThinking);
        Assert.Equal(Player.O, game.CurrentTurn);
    }

    [Fact]
    public void MakeMove_WinningMove_SetsStateWonAndIncrementsScore()
    {
        var game = new TicTacToeGame(initialMode: GameMode.PlayerVsPlayer);
        GameWonEventArgs? wonArgs = null;
        game.GameWon += (_, e) => wonArgs = e;

        // X: 0, 1, 2 (victoria horizontal)
        // O: 3, 4
        game.MakeMove(0); // X
        game.MakeMove(3); // O
        game.MakeMove(1); // X
        game.MakeMove(4); // O
        game.MakeMove(2); // X gana

        Assert.Equal(GameState.Won, game.State);
        Assert.True(game.IsGameOver);
        Assert.Equal(1, game.Score.WinsX);
        Assert.Equal(0, game.Score.WinsO);
        Assert.NotNull(wonArgs);
        Assert.Equal(Player.X, wonArgs.Winner);
        Assert.Equal(new WinLine(0, 1, 2), wonArgs.WinningLine);

        // Movimientos adicionales deben ser rechazados tras ganar
        Assert.False(game.MakeMove(5));
    }

    [Fact]
    public void MakeMove_DrawGame_SetsStateDrawAndIncrementsScore()
    {
        var game = new TicTacToeGame(initialMode: GameMode.PlayerVsPlayer);
        bool drawFired = false;
        game.GameDrawn += (_, _) => drawFired = true;

        // X O X
        // X O O
        // O X X
        int[] moves = [0, 1, 2, 4, 3, 5, 7, 6, 8];
        foreach (int move in moves)
        {
            game.MakeMove(move);
        }

        Assert.Equal(GameState.Draw, game.State);
        Assert.True(game.IsGameOver);
        Assert.True(drawFired);
        Assert.Equal(1, game.Score.Draws);
    }

    [Fact]
    public void StartNewRound_ResetsBoardAndTurn_PreservesScore()
    {
        var game = new TicTacToeGame(initialMode: GameMode.PlayerVsPlayer);
        game.MakeMove(0); // X
        game.MakeMove(3); // O
        game.MakeMove(1); // X
        game.MakeMove(4); // O
        game.MakeMove(2); // X gana (X: 1 victoria)

        bool roundStartedFired = false;
        game.RoundStarted += (_, _) => roundStartedFired = true;

        game.StartNewRound();

        Assert.True(roundStartedFired);
        Assert.Equal(Player.X, game.CurrentTurn);
        Assert.Equal(GameState.InProgress, game.State);
        Assert.False(game.IsGameOver);
        Assert.Equal(1, game.Score.WinsX); // Se mantiene el marcador
        Assert.Equal(0, game.Board.MovesCount);
    }

    [Fact]
    public void ResetScore_ResetsAllCountersToZero()
    {
        var game = new TicTacToeGame(initialMode: GameMode.PlayerVsPlayer);
        game.MakeMove(0);
        game.MakeMove(3);
        game.MakeMove(1);
        game.MakeMove(4);
        game.MakeMove(2); // X gana

        ScoreChangedEventArgs? scoreArgs = null;
        game.ScoreChanged += (_, e) => scoreArgs = e;

        game.ResetScore();

        Assert.Equal(0, game.Score.WinsX);
        Assert.Equal(0, game.Score.WinsO);
        Assert.Equal(0, game.Score.Draws);
        Assert.NotNull(scoreArgs);
        Assert.Equal(0, scoreArgs.WinsX);
    }

    [Fact]
    public void SetGameMode_SwitchesModeAndRestartsRound()
    {
        var game = new TicTacToeGame(initialMode: GameMode.PlayerVsAi);
        game.MakeMove(0);

        game.SetGameMode(GameMode.PlayerVsPlayer);

        Assert.Equal(GameMode.PlayerVsPlayer, game.Mode);
        Assert.Equal(0, game.Board.MovesCount);
        Assert.Equal(Player.X, game.CurrentTurn);
    }
}
