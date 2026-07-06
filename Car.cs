using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTutorial
{
    public class Car
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Driver { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{Color} {Brand} is driving by {Driver}");
        }
    }
}
