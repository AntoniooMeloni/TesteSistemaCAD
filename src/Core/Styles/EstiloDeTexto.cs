namespace VeraxCAD2D.Core.Styles
{
    /// <summary>
    /// Define um estilo para entidades de Texto.
    /// Controla a fonte, tamanho e outras propriedades.
    /// </summary>
    public class EstiloDeTexto
    {
        /// <summary>
        /// O nome do estilo (ex: "ABNT-2.5").
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// O nome da fonte (ex: "Arial", "ISOCPEUR", "Calibri").
        /// </summary>
        public string NomeDaFonte { get; set; }

        /// <summary>
        /// A altura do texto em unidades do desenho (normalmente mm).
        /// </summary>
        public double TamanhoDoTexto { get; set; }

        /// <summary>
        /// O fator de largura (ex: 1.0 = normal, 0.8 = condensado).
        /// </summary>
        public double FatorDeLargura { get; set; }

        public EstiloDeTexto(string nome, string nomeDaFonte, double tamanhoDoTexto, double fatorDeLargura = 1.0)
        {
            Nome = nome;
            NomeDaFonte = nomeDaFonte;
            TamanhoDoTexto = tamanhoDoTexto;
            FatorDeLargura = fatorDeLargura;
        }

        /// <summary>
        /// Cria um EstiloDeTexto padrão ABNT com 2.5mm de altura.
        /// Usamos Arial por ser uma fonte segura e universal no Windows.
        /// </summary>
        public static EstiloDeTexto PadraoABNT_2_5 => 
            new EstiloDeTexto("ABNT-2.5", "Arial", 2.5, 0.8);
            
        /// <summary>
        /// Cria um EstiloDeTexto padrão ABNT com 3.5mm de altura.
        /// </summary>
        public static EstiloDeTexto PadraoABNT_3_5 => 
            new EstiloDeTexto("ABNT-3.5", "Arial", 3.5, 0.8);
    }
}