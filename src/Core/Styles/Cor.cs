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

        public string ToHex()
        {
            return $"#{R:X2}{G:X2}{B:X2}";
        }

        public static Cor FromHex(string hex)
        {
            if (hex.StartsWith("#"))
                hex = hex.Substring(1);

            byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

            return new Cor(r, g, b);
        }

        public (double H, double S, double V) ToHsv()
        {
            double r = R / 255.0;
            double g = G / 255.0;
            double b = B / 255.0;

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));

            double h = 0;
            if (max == min)
                h = 0;
            else if (max == r)
                h = (60 * ((g - b) / (max - min)) + 360) % 360;
            else if (max == g)
                h = (60 * ((b - r) / (max - min)) + 120);
            else if (max == b)
                h = (60 * ((r - g) / (max - min)) + 240);

            double s = (max == 0) ? 0 : (1 - (min / max));
            double v = max;

            return (h, s, v);
        }

        public static Cor FromHsv(double h, double s, double v)
        {
            double r = 0, g = 0, b = 0;

            int i = (int)(h / 60) % 6;
            double f = h / 60 - (int)(h / 60);
            double p = v * (1 - s);
            double q = v * (1 - f * s);
            double t = v * (1 - (1 - f) * s);

            switch (i)
            {
                case 0: r = v; g = t; b = p; break;
                case 1: r = q; g = v; b = p; break;
                case 2: r = p; g = v; b = t; break;
                case 3: r = p; g = q; b = v; break;
                case 4: r = t; g = p; b = v; break;
                case 5: r = v; g = p; b = q; break;
            }

            return new Cor((byte)(r * 255), (byte)(g * 255), (byte)(b * 255));
        }
    }
}
