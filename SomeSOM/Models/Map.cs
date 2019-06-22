using System;
using System.Collections.Generic;
using SomeSOM.Services;

namespace SomeSOM.Models
{
    public class Map
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public SOMColor[,] Grid { get; set; }

        public Map(int height, int width)
        {
            Height = height;
            Width = width;
            Grid = new SOMColor[height,width];
        }

        /// <summary>
        /// Initializes the node weights.
        /// </summary>
        public void InitializeNodeWeights()
        {
            List<SOMColor> colors = new List<SOMColor>();
            colors = SOMColor.GetRandomColors(Width * Height);

             for(int i=0; i < Height; i++)
                {
                    for(int j=0; j < Width; j++)
                    {
                    Grid[i, j] = new SOMColor(colors[0].Red, colors[0].Green, colors[0].Blue);
                        colors.RemoveAt(0);
                    }
                }
           

        }
    }
}
