namespace TresEnRayaApp.Services;

/// <summary>
/// Contrato para la reproducción de efectos de sonido en la aplicación.
/// </summary>
public interface ISoundService : IDisposable
{
    /// <summary>
    /// Reproduce el efecto de colocación de ficha.
    /// </summary>
    void PlayMove();

    /// <summary>
    /// Reproduce el efecto auditivo de victoria.
    /// </summary>
    void PlayWin();

    /// <summary>
    /// Reproduce el efecto auditivo de partida empatada.
    /// </summary>
    void PlayDraw();
}
