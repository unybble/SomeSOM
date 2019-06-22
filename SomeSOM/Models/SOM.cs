using System;
namespace SomeSOM.Models
{
    public class SOM
    {
        public Map Map { get; set; }
        public int IterationLimit { get; set; }
        public int CurrentIteration { get; set; }

        public SOM(Map map, int iterationLimit)
        {
            Map = map;
            IterationLimit = iterationLimit;
            CurrentIteration = 0;
        }
    }
}
