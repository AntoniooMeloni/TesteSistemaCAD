using VeraxCAD2D.Core.Geometry;

namespace VeraxCAD2D.Core.Geometry
{
    /// <summary>
    /// Representa uma entidade de Círculo 2D.
    /// </summary>
    public class Circulo : IEntidadeGeometrica
    {
        public Ponto2D Centro { get; set; }
        public double Raio { get; set; }

        public Circulo(Ponto2D centro, double raio)
        {
            Centro = centro;
            Raio = raio;
        }
        public Cor Cor { get; set; } = Cor.PorCamada;
        public TipoDeLinha TipoDeLinha { get; set; } = TipoDeLinha.PorCamada;
        public EspessuraLinha Espessura { get; set; } = EspessuraLinha.PorCamada;
    }
}