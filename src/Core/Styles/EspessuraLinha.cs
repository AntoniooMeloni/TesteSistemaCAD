namespace VeraxCAD2D.Core.Styles
{
    /// <summary>
    /// Enumeração para espessuras de linha padronizadas pela ABNT (ISO 128).
    /// Usar um enum previne que o usuário escolha valores "quebrados" (ex: 0.12mm).
    /// </summary>
    public enum EspessuraLinha
    {
        // Os nomes representam o valor em mm (ex: mm013 = 0.13mm)
        mm013, // Usada para linhas de cota, auxiliares
        mm018,
        mm025, // Usada para linhas de contorno finas
        mm035,
        mm050, // Usada para linhas de contorno principais
        mm070,
        mm100,
        mm140,
        mm200,
        PorCamada
    }
}