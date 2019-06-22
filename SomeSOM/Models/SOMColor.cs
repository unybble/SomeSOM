using System;
using System.Collections.Generic;
using System.Drawing;

namespace SomeSOM.Models
{
    public class SOMColor
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public string Hex {
            get
            {
                Color c = Color.FromArgb(Red, Green, Blue);

                return "#"+c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
            }
        }

        public SOMColor(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        /// <summary>
        /// Gets the random colors.
        /// </summary>
        /// <returns>The random colors.</returns>
        /// <param name="number">Number.</param>
        public static List<SOMColor> GetRandomColors(int number)
        {
            List<SOMColor> colors = new List<SOMColor>();

            Random rand = new Random();

            for(int i=0; i < number; i++)
            {
                colors.Add(new SOMColor(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256)));
            }
            return colors;
        }
    }
}
