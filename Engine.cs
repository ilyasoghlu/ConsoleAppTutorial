using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTutorial
{
    public class Engine
    {
        public double Volume { get; }
        public int HorsePower { get; }

        public Engine(double volume, int horsePower)
        {
            Volume = volume;
            HorsePower = horsePower;
        }
    }
}
