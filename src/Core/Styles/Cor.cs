namespace VeraxCAD2D.Core.Styles
{
    /// <summary>
    /// Representa uma cor no padrão RGB.
    /// 'struct' é mais leve que 'class' para objetos simples como este.
    /// </summary>
    public struct Cor
    {
        // As cores são representadas por valores de 0 (escuro) a 255 (claro).
        public byte R { get; set; } // Red
        public byte G { get; set; } // Green
        public byte B { get; set; } // Blue

        public Cor(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        // --- Atalhos Estáticos (Cores Padrão) ---
        // Isso facilita usar cores comuns sem ter que lembrar o RGB.
        
        public static Cor Branco => new Cor(255, 255, 255);
        public static Cor Preto => new Cor(0, 0, 0);
        public static Cor Vermelho => new Cor(255, 0, 0);
        public static Cor Verde => new Cor(0, 255, 0);
        public static Cor Azul => new Cor(0, 0, 255);
        public static Cor Amarelo => new Cor(255, 255, 0);
        public static Cor Ciano => new Cor(0, 255, 255);
        public static Cor Magenta => new Cor(255, 0, 255);
        public static Cor PorCamada => new Cor(255, 255, 255);
    }
}