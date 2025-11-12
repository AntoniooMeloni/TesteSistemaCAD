using System.Collections.Generic; // Para usar List<>
using System.Linq; // Para usar o .FirstOrDefault()
using VeraxCAD2D.Core.Geometry; // Para usar IEntidadeGeometrica
using VeraxCAD2D.Core.Styles; // Para usar EstiloDeTexto, EstiloDeCota, etc.

namespace VeraxCAD2D.Core.Model
{
    /// <summary>
    /// Representa o documento de desenho principal.
    /// Contém todas as camadas, estilos e configurações.
    /// </summary>
    public class Documento
    {
        /// <summary>
        /// A lista de todas as camadas presentes neste documento.
        /// </summary>
        public List<Camada> Camadas { get; private set; }

        /// <summary>
        /// A lista de todos os Estilos de Texto disponíveis no documento.
        /// </summary>
        public List<EstiloDeTexto> EstilosDeTexto { get; private set; }

        /// <summary>
        /// A lista de todos os Estilos de Cota disponíveis no documento.
        /// </summary>
        public List<EstiloDeCota> EstilosDeCota { get; private set; }


        /// <summary>
        /// Construtor do Documento - ATUALIZADO
        /// </summary>
        public Documento()
        {
            // --- Inicialização de Listas ---
            Camadas = new List<Camada>();
            EstilosDeTexto = new List<EstiloDeTexto>();
            EstilosDeCota = new List<EstiloDeCota>();

            // --- Criação de Padrões ---
            
            // 1. Criar camada padrão
            CriarNovaCamada("0");

            // 2. Criar Estilos de Texto Padrão ABNT
            var estiloTexto2_5 = EstiloDeTexto.PadraoABNT_2_5;
            EstilosDeTexto.Add(estiloTexto2_5);

            var estiloTexto3_5 = EstiloDeTexto.PadraoABNT_3_5;
            EstilosDeTexto.Add(estiloTexto3_5);

            // 3. Criar Estilo de Cota Padrão ABNT
            // (Usando o traço oblíquo e o texto de 2.5mm)
            var estiloCotaPadrao = new EstiloDeCota(
                nome: "ABNT-Traço",
                estiloDoTexto: estiloTexto2_5,       // Usa o texto de 2.5mm
                tipoDeSeta: TipoDeSetaCota.TracoObliquo,
                tamanhoDaSeta: 2.0,                  // Traço de 2mm
                extensaoLinhaCota: 1.5,              // "Passa" 1.5mm
                offsetDaOrigem: 1.5                  // "Distância" 1.5mm
            );
            EstilosDeCota.Add(estiloCotaPadrao);
        }

        /// <summary>
        /// Método para criar uma nova camada no documento.
        /// </summary>
        public Camada CriarNovaCamada(string nome)
        {
            // Verifica se já existe uma camada com esse nome
            if (Camadas.Any(c => c.Nome == nome))
            {
                // (No futuro, devemos tratar esse erro)
                return null;
            }

            var novaCamada = new Camada(nome);
            Camadas.Add(novaCamada);
            return novaCamada;
        }

        /// <summary>
        /// Encontra uma camada pelo seu nome.
        /// </summary>
        public Camada GetCamada(string nome)
        {
            // Usa .FirstOrDefault() para encontrar a primeira camada
            // que tenha o nome procurado, ou retorna 'null' se não encontrar.
            return Camadas.FirstOrDefault(c => c.Nome == nome);
        }

        /// <summary>
        /// Adiciona uma entidade (Linha, Circulo, etc.) a uma camada específica.
        /// </summary>
        public void AdicionarEntidade(IEntidadeGeometrica entidade, string nomeCamada)
        {
            var camada = GetCamada(nomeCamada);

            if (camada != null)
            {
                camada.Entidades.Add(entidade);
            }
            else
            {
                // O que fazer se a camada não existir?
                // Por segurança, podemos adicionar na camada "0"
                GetCamada("0").Entidades.Add(entidade);
            }
        }

        // --- Métodos de busca de Estilo ---
        
        /// <summary>
        /// Encontra um EstiloDeTexto pelo seu nome.
        /// </summary>
        public EstiloDeTexto GetEstiloDeTexto(string nome)
        {
            return EstilosDeTexto.FirstOrDefault(e => e.Nome == nome);
        }

        /// <summary>
        /// Encontra um EstiloDeCota pelo seu nome.
        /// </summary>
        public EstiloDeCota GetEstiloDeCota(string nome)
        {
            return EstilosDeCota.FirstOrDefault(e => e.Nome == nome);
        }
    }
    public List<DefinicaoDeBloco> DefinicoesDeBloco { get; private set; }
    }