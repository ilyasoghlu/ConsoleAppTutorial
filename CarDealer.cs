using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTutorial
{
    internal class CarDealer
    {
        // static fields
        public static string CarDealerName = "Miracle Auto Dealer";
        public static string DealerLocation = "New York, 55th avenue";
        public static int TotalCars = 0;

        // instance fields
        public string CarBrand;
        public string CarModel;
        public string CarComplectation;
        public DateTime ProductionDate;
        public decimal Price;

        // constructor
        public CarDealer(string carBrand, string carModel, string carComplectation, DateTime productionDate, decimal carPrice)
        {
            CarBrand = carBrand;
            CarModel = carModel;
            CarComplectation = carComplectation;
            ProductionDate = productionDate;
            Price = carPrice;

            TotalCars++;
        }

        // instance methods
        public void CarInfo()
        {
            Console.WriteLine($"Brand: {CarBrand}");
            Console.WriteLine($"Model: {CarModel}");
            Console.WriteLine($"Compectation: {CarComplectation}");
            Console.WriteLine($"Production date: {ProductionDate:yyyy}");
            Console.WriteLine($"Price: {Price}");
        }


        // static methods

        public static void DealerInfo()
        {
            Console.WriteLine($"Auto dealer: {CarDealerName}");
            Console.WriteLine($"Address: {DealerLocation}");
            Console.WriteLine($"Total cars: {TotalCars}");
        } 

    }
}


