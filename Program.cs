using System;
using System.Collections.Generic;

namespace LagerUke5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pants = new ClothingItem("Olabukse", 13, 299.99, "Bukse med unødvendige hull");
            var gameConsole = new ElectronicItem("Game Master XXX 69", 0, 7000,
                "Ny spillkonsoll med beste grafikk evver i en måneds tid, men det er ingen spill til den enda, og scalpers kjøper hele beholdningen og legger på E-Bay til hundretusen");

            var products = new List<ISellable>() { pants, gameConsole };

            foreach (var product in products)
            {
                int numberToBuy = 2;
                Console.WriteLine($"Det koster {product.CalculatePrice(numberToBuy)} for {numberToBuy} stykker av {product.Name}, så langt lageret rekker.");
            }

            Console.ReadLine();
        }
    }
}
