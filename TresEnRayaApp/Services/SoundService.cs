namespace TresEnRayaApp.Services;

using System.Media;

/// <summary>
/// Servicio de sonido nativo basado en <see cref="SoundPlayer"/> y recursos multimedia de Windows.
/// </summary>
public sealed class SoundService : ISoundService
{
    private readonly SoundPlayer? _playerMove;
    private readonly SoundPlayer? _playerWin;
    private readonly SoundPlayer? _playerDraw;
    private bool _disposed;

    public SoundService()
    {
        try
        {
            string mediaDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Media");
            string pathMove = Path.Combine(mediaDir, "chord.wav");
            string pathWin = Path.Combine(mediaDir, "tada.wav");
            string pathDraw = Path.Combine(mediaDir, "ding.wav");

            if (File.Exists(pathMove)) _playerMove = new SoundPlayer(pathMove);
            if (File.Exists(pathWin)) _playerWin = new SoundPlayer(pathWin);
            if (File.Exists(pathDraw)) _playerDraw = new SoundPlayer(pathDraw);
        }
        catch
        {
            // Captura defensiva si el entorno no permite acceso al directorio multimedia
        }
    }

    public void PlayMove() => SafePlay(_playerMove);

    public void PlayWin() => SafePlay(_playerWin);

    public void PlayDraw() => SafePlay(_playerDraw);

    private static void SafePlay(SoundPlayer? player)
    {
        try
        {
            player?.Play();
        }
        catch
        {
            // Captura defensiva si el dispositivo de audio se encuentra ocupado o no disponible
        }
    }

    public void Dispose()
    {
        if (_disposed) return;

        _disposed = true;
        _playerMove?.Dispose();
        _playerWin?.Dispose();
        _playerDraw?.Dispose();
    }
}
