using System;
using System.Collections.Generic;
using SomeSOM.Services;

namespace SomeSOM.Models
{
    public class Map
    {
        public int Dimension { get; set; }
        public SOMColor[,] Grid { get; set; }

        public Map(int dimension)
        {
            Dimension = dimension;
            Grid = new SOMColor[dimension, dimension];
        }

        /// <summary>
        /// Initializes the node weights.
        /// </summary>
        public void InitializeNodeWeights()
        {
            List<SOMColor> colors = new List<SOMColor>();
            colors = SOMColor.GetRandomColors(Dimension * Dimension);

             for(int i=0; i < Dimension; i++)
                {
                    for(int j=0; j < Dimension; j++)
                    {
                    Grid[i, j] = new SOMColor(colors[0].Red, colors[0].Green, colors[0].Blue);
                        colors.RemoveAt(0);
                    }
                }
           

        }
    }
}
