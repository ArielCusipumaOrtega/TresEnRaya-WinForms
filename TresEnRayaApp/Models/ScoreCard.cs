namespace TresEnRayaApp.Models;

/// <summary>
/// Gestiona las estadísticas y el historial de victorias y empates.
/// </summary>
public sealed class ScoreCard
{
    public int WinsX { get; private set; }
    public int WinsO { get; private set; }
    public int Draws { get; private set; }

    public void RecordWin(Player winner)
    {
        if (winner == Player.X)
        {
            WinsX++;
        }
        else if (winner == Player.O)
        {
            WinsO++;
        }
    }

    public void RecordDraw()
    {
        Draws++;
    }

    public void Reset()
    {
        WinsX = 0;
        WinsO = 0;
        Draws = 0;
    }
}
