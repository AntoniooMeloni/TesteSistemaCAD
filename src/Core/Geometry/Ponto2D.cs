namespace VeraxCAD2D.Core.Geometry
{
    /// <summary>
    /// Representa um ponto 2D no espaço do "mundo".
    /// Usamos 'struct' por ser leve e eficiente para geometria.
    /// </summary>
    public struct Ponto2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Ponto2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Você pode adicionar métodos matemáticos aqui depois, ex:
        // public double DistanciaPara(Ponto2D outroPonto) { ... }
    }
}