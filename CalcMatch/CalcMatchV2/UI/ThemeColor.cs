using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMatchV2.UI
{
    public static class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecundaryColor { get; set; }

        public static List<string> ColorList = new List<string>() { "#4C0033",
                                                                    "#790252",
                                                                    "#461959",
                                                                    "#643A6B",
                                                                    "#A31ACB",
                                                                    "#58287F",
                                                                    "#C147E9",
                                                                    "#810CA8",
                                                                    "#6F1AB6"};
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            //Se o fator de correção for menor que 0, escurece a cor.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            //Se o fator de correção for maior que zero, clareia a cor.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }

}
