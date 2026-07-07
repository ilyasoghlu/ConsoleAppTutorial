using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTutorial
{
    public class Market
    {
        // Market haqqında ümumi məlumatlar (static )
        public static int TotalMarkets = 0;
        public static string MarketName = "Bravo marketlər şəbəkəsi";


        // Market haqda instance infolar
        public string BranchName;
        public string BranchLocation;



        // Constructor 

        public Market(string branchName, string branchLocation)
        {
            BranchName = branchName;
            BranchLocation = branchLocation;


            TotalMarkets++;
        }

       

        // Instance Methods

        public void ShowBranchInfo()
        {
            Console.WriteLine($"Brach Name: {BranchName}");
            Console.WriteLine($"Brach Location: {BranchLocation}");
        }


        // static methods

        public static void ShowMarketInfo()
        {
            Console.WriteLine($"Market Name: {MarketName}");
            Console.WriteLine($"Total Market number: {TotalMarkets}");
        }
    }

}
