using System;

namespace _06._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
           double budget = double.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();

            double price = 0;
            string destination = "";
           string place = "";
            //•	При 100лв. или по-малко – някъде в България
            //            o Лято – 30 % от бюджета
            //           o   Зима – 70 % от бюджета
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (sezon == "summer")
                {
                    price = budget * 0.3;
                    place = "Camp";
                   
                }
                else
                {
                    price = budget * 0.7;
                    place = "Hotel";
                }

            }
            //•	При 1000лв.или по малко – някъде на Балканите
            //o   Лято – 40 % от бюджета
            //o   Зима – 80 % от бюджета
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (sezon == "summer")
                {
                    price = budget * 0.4;
                    place = "Camp";
                }
                else
                {
                    price = budget * 0.8;
                    place = "Hotel";
                }
            }
            //•	При повече от 1000лв. – някъде из Европа
            //o   При пътуване из Европа, независимо от сезона ще похарчи 90 % от бюджета.
            else if (budget > 1000)
            {
                destination = "Europe";
                price = budget * 0.9;
                place = "Hotel";
               
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {price:f2}");
        }
    }
}
