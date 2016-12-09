using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VisulazationPackage
{
    class Color_Functions
    {
        public static Color[] colors = new[] { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue };


        public static ColorBlend createContinuousColorBlend()
        {
            ColorBlend cb = new ColorBlend();
            cb.Positions = new[] { 0, 1 / 5f, 2 / 5f, 3 / 5f, 4 / 5f, 1 };
            cb.Colors = colors;
            return cb;
        }

        public static void createDiscreteColors(Panel colorsPanels)
        {
            int stp = colorsPanels.Width / 5;
            Graphics g = colorsPanels.CreateGraphics();
            g.FillRectangle(Brushes.Red, 0, 0, stp, colorsPanels.Height);
            g.FillRectangle(Brushes.Orange, stp, 0, 2 * stp, colorsPanels.Height);
            g.FillRectangle(Brushes.Yellow, 2 * stp, 0, 3 * stp, colorsPanels.Height);
            g.FillRectangle(Brushes.Green, 3 * stp, 0, 4 * stp, colorsPanels.Height);
            g.FillRectangle(Brushes.Blue, 4 * stp, 0, colorsPanels.Width, colorsPanels.Height);
        }
        public static void createContinuousColors(PaintEventArgs e, Rectangle rect)
        {
            LinearGradientBrush br = new LinearGradientBrush(rect, Color.Red, Color.Blue, 0, false);
            ColorBlend cb = new ColorBlend();
            cb.Positions = new[] { 0, 1 / 5f, 2 / 5f, 3 / 5f, 4 / 5f, 1 };
            cb.Colors = new[] { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Blue };
            br.InterpolationColors = cb;
            e.Graphics.FillRectangle(br, rect);

        }

        public static void ColorToValue(Color color, double Smin, double Smax, int type, out float value)
        {
            value = -1;

            if (type == 0)
            {
                value = ((float)Convert.ToDouble((Smax - Smin) / colors.Length) * (float)Convert.ToDouble(GetColorIndex(color, colors))); ;
                return;

            }
            else if (type == 1)
            {

                value = -1;
                return;
            }
            value = -1;
        }

        public static void ValueToColor(double value, double Smin, double Smax, int type, out double r, out double g, out double b)
        {
            r = 0;
            g = 0;
            b = 0;
            Color targetColor = new Color();
            int nColors = colors.Length;

            if (value <= Smin)
            {
                targetColor = colors[0];
                r = targetColor.R;
                g = targetColor.G;
                b = targetColor.B;
                return;
            }
            if (value >= Smax)
            {
                targetColor = colors[nColors - 1];
                r = targetColor.R;
                g = targetColor.G;
                b = targetColor.B;
                return;
            }

            if (type == 1)
            {
                getContinuousColor(value, Smin, Smax, out r, out g, out b);

            }

            else if (type == 0)
            {

                int inx = Convert.ToInt32(5.0 * ((value - (float)Convert.ToDouble(Smin)) / ((float)Convert.ToDouble(Smax) - (float)Convert.ToDouble(Smin))));

                if (inx > 4) inx = 4;
                else if (inx < 0) inx = 0;
                targetColor = colors[inx];
                r = targetColor.R;
                g = targetColor.G;
                b = targetColor.B;
            }

        }

        public static void getContinuousColor(double value, double Smin, double Smax, out double red, out double green, out double blue)
        {

            double deltaS = (Smax - Smin) / 5;
            double dS = (value - Smin) / deltaS;
            double i = Math.Floor(dS);
            double alpha = dS - i;
            red = 0;
            green = 0;
            blue = 0;

            // Color.Blue, Color.Green, Color.Yellow, Color.Orange, Color.Red
            //color between blue&blue
            if (i == 0)
            {
                red = Color.Red.R + alpha * (Color.Orange.R - Color.Red.R);
                green = Color.Red.G + alpha * (Color.Orange.G - Color.Red.G);
                blue = Color.Red.B + alpha * (Color.Orange.B - Color.Red.B);
            }
            //color between yellow&green
            else if (i == 1)
            {
                red = Color.Orange.R + alpha * (Color.Yellow.R - Color.Orange.R);
                green = Color.Orange.G + alpha * (Color.Yellow.G - Color.Orange.G);
                blue = Color.Orange.B + alpha * (Color.Yellow.B - Color.Orange.B);
            }
            //color between green&blue
            else if (i == 2)
            {
                red = Color.Yellow.R + alpha * (Color.Green.R - Color.Yellow.R);
                green = Color.Yellow.G + alpha * (Color.Green.G - Color.Yellow.G);
                blue = Color.Yellow.B + alpha * (Color.Green.B - Color.Yellow.B);
            }


            //color between orange&yellow
            else if (i == 3)
            {
                red = Color.Green.R + alpha * (Color.Blue.R - Color.Green.R);
                green = Color.Green.G + alpha * (Color.Blue.G - Color.Green.G);
                blue = Color.Green.B + alpha * (Color.Blue.B - Color.Green.B);
            }

             //color between red&orange
            else if (i == 4)
            {
                red = Color.Blue.R;
                green = Color.Blue.G;
                blue = Color.Blue.B;
            }

        }
        private static int GetColorIndex(Color color, Color[] colors)
        {
            int size = colors.Length;
            for (int i = 0; i < size; i++)
            {
                if (colors[i].R == color.R && colors[i].G == color.G && colors[i].B == color.B)
                {
                    return i;
                }
            }
            return 0;
        }


    }
}
