// "using" importa as bibliotecas que precisamos
using System.Collections.Generic; // Para usar List<>
using VeraxCAD2D.Core.Geometry; // Para usar IEntidadeGeometrica

// O namespace agora é .Model
namespace VeraxCAD2D.Core.Model
{
    /// <summary>
    /// Representa uma Camada (Layer) do desenho.
    /// Uma camada agrupa entidades e controla suas propriedades.
    /// </summary>
    public class Camada
    {
        /// <summary>
        /// O nome da camada (ex: "Paredes", "Cotas", "0").
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Controla se a camada está visível ou não.
        /// </summary>
        public bool Visivel { get; set; }
        
        // (Futuramente, adicionaremos Cor, TipoDeLinha, etc.)

        /// <summary>
        /// A lista de todas as entidades geométricas que pertencem a esta camada.
        /// </summary>
        /// /// <summary>
        /// A cor padrão para entidades nesta camada.
        /// </summary>
        public Cor Cor { get; set; }

        /// <summary>
        /// O tipo de linha padrão para entidades nesta camada.
        /// </summary>
        public TipoDeLinha TipoDeLinha { get; set; }

        /// <summary>
        /// A espessura de linha padrão para entidades nesta camada.
        /// </summary>
        public EspessuraLinha Espessura { get; set; }
        public List<IEntidadeGeometrica> Entidades { get; private set; }

        /// <summary>
        /// Construtor da Camada.
        /// </summary>
        /// <param name="nome">O nome da nova camada.</param>
        public Camada(string nome)
        {
            Nome = nome;
            Visivel = true; // Por padrão, uma nova camada é visível

            // Inicializa a lista de entidades.
            // Sem isso, 'Entidades' seria 'null' e daria erro.
            Entidades = new List<IEntidadeGeometrica>(); 
            // --- VALORES PADRÃO (NOVOS) ---
            // Define valores padrão sensatos para uma nova camada
            Cor = Cor.Branco;
            TipoDeLinha = TipoDeLinha.Continua;
            Espessura = EspessuraLinha.mm025;
        }
    }
}