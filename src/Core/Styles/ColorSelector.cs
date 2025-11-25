using System;

namespace VeraxCAD2D.Core.Styles
{
    public class ColorSelector
    {
        private Cor _selectedCor;

        public ColorSelector(Cor initialCor)
        {
            _selectedCor = initialCor;
        }

        public void SetCor(Cor newCor)
        {
            _selectedCor = newCor;
        }

        public Cor GetCor()
        {
            return _selectedCor;
        }

        public string GetRgbString()
        {
            return $"{_selectedCor.R},{_selectedCor.G},{_selectedCor.B}";
        }

        public void SetFromRgbString(string rgbString)
        {
            var parts = rgbString.Split(',');
            if (parts.Length == 3 &&
                byte.TryParse(parts[0], out byte r) &&
                byte.TryParse(parts[1], out byte g) &&
                byte.TryParse(parts[2], out byte b))
            {
                _selectedCor = new Cor(r, g, b);
            }
        }

        public string GetHexString()
        {
            return _selectedCor.ToHex();
        }

        public void SetFromHexString(string hexString)
        {
            _selectedCor = Cor.FromHex(hexString);
        }

        public string GetHsvString()
        {
            var (h, s, v) = _selectedCor.ToHsv();
            return $"{h:F0}°,{s * 100:F0}%,{v * 100:F0}%";
        }

        public void SetFromHsvString(string hsvString)
        {
            var parts = hsvString.Replace("°", "").Replace("%", "").Split(',');
            if (parts.Length == 3 &&
                double.TryParse(parts[0], out double h) &&
                double.TryParse(parts[1], out double s) &&
                double.TryParse(parts[2], out double v))
            {
                _selectedCor = Cor.FromHsv(h, s / 100.0, v / 100.0);
            }
        }
    }
}
