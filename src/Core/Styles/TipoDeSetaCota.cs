namespace VeraxCAD2D.Core.Styles
{
    /// <summary>
    /// Enumeração dos possíveis tipos de terminais de linha de cota.
    /// </summary>
    public enum TipoDeSetaCota
    {
        /// <summary>
        /// Uma seta fechada e preenchida (comum em mecânica).
        /// </summary>
        SetaPreenchida,

        /// <summary>
        /// Um traço a 45 graus (comum em arquitetura/civil).
        /// </summary>
        TracoObliquo,

        /// <summary>
        /// Um pequeno ponto.
        /// </summary>
        Ponto
        
        // (Podemos adicionar SetaVazia, etc. no futuro)
    }
}