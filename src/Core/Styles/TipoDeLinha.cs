using System.Collections.Generic;

namespace VeraxCAD2D.Core.Styles
{
    /// <summary>
    /// Representa um padrão de tipo de linha (ex: tracejada).
    /// </summary>
    public class TipoDeLinha
    {
        /// <summary>
        /// O nome do tipo de linha (ex: "Contínua", "Tracejada").
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// O padrão de traços e espaços.
        /// Ex: [10, 5] = Traço de 10 unidades, Espaço de 5 unidades.
        /// Ex: [10, 5, 2, 5] = Traço 10, Espaço 5, Traço 2, Espaço 5.
        /// Uma lista vazia significa "Contínua".
        /// </summary>
        public List<double> Padrao { get; private set; }

        public TipoDeLinha(string nome, List<double> padrao = null)
        {
            Nome = nome;
            // Se o padrão for nulo ou vazio, cria uma lista vazia (linha contínua)
            Padrao = padrao ?? new List<double>(); 
        }

        // --- Atalhos Estáticos (Tipos Padrão ABNT) ---
        
        public static TipoDeLinha Continua => new TipoDeLinha("Contínua");
        
        // Linha Tracejada (ABNT: usada para contornos não visíveis)
        public static TipoDeLinha Tracejada => new TipoDeLinha("Tracejada", new List<double> { 8, 4 });
        
        // Linha Traço-Ponto (ABNT: usada para linhas de centro e simetria)
        public static TipoDeLinha TracoPonto => new TipoDeLinha("Traço-Ponto", new List<double> { 10, 3, 2, 3 });

        public static TipoDeLinha PorCamada => new TipoDeLinha("PorCamada");
    }
}