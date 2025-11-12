namespace VeraxCAD2D.Core.Styles
{
    /// <summary>
    /// Define um estilo completo para entidades de Cota (Dimensão).
    /// </summary>
    public class EstiloDeCota
    {
        /// <summary>
        /// O nome do estilo (ex: "ABNT-Traço").
        /// </summary>
        public string Nome { get; set; }

        // --- Propriedades do Texto ---
        /// <summary>
        /// O EstiloDeTexto que esta cota usará.
        /// </summary>
        public EstiloDeTexto EstiloDoTexto { get; set; }

        // --- Propriedades das Setas/Linhas ---
        /// <summary>
        /// O símbolo usado no final da linha de cota (seta, traço, etc.).
        /// </summary>
        public TipoDeSetaCota TipoDeSeta { get; set; }

        /// <summary>
        /// O tamanho da seta ou do traço oblíquo (em unidades).
        /// </summary>
        public double TamanhoDaSeta { get; set; }

        /// <summary>
        /// O quanto a linha de cota se estende além da linha auxiliar.
        /// (O "passar" da linha de cota).
        /// </summary>
        public double ExtensaoLinhaCota { get; set; }

        /// <summary>
        /// O espaço entre a geometria (origem) e o início da linha auxiliar.
        /// </summary>
        public double OffsetDaOrigem { get; set; }


        public EstiloDeCota(string nome, EstiloDeTexto estiloDoTexto, TipoDeSetaCota tipoDeSeta, 
                            double tamanhoDaSeta, double extensaoLinhaCota, double offsetDaOrigem)
        {
            Nome = nome;
            EstiloDoTexto = estiloDoTexto;
            TipoDeSeta = tipoDeSeta;
            TamanhoDaSeta = tamanhoDaSeta;
            ExtensaoLinhaCota = extensaoLinhaCota;
            OffsetDaOrigem = offsetDaOrigem;
        }
    }
}