using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTutorial
{
    public class Car
    {
        public string Brand { get;  }
        public string Model { get;  }
        public int Year { get; }
        public string Owner { get; }
        public string VIN { get; }
        public Engine Engine { get; }

            public Car(string brand, string model, int year, string owner, string vin, Engine engine)
                {
            if (string.IsNullOrWhiteSpace(brand))
                throw new ArgumentException("Brand cant be empty");
            if (string.IsNullOrEmpty(model))
                throw new ArgumentException("Model cant be empty");
            if (year < 1886)
            throw new ArgumentException("Year is not valid");
            if (string.IsNullOrWhiteSpace(owner))
                throw new ArgumentException("Owner cant be empty");
            if (string.IsNullOrEmpty(vin))
                throw new ArgumentException("VIN cant be empty");
            if (engine == null)
                throw new ArgumentNullException(nameof(engine));

                    Brand = brand;
                    Model = model;
                    Year = year;
                    Owner = owner;
                    VIN = vin;
                    Engine = engine;
                }

            
       
    }
}
