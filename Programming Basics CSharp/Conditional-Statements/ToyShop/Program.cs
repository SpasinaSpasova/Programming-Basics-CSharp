using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int tracks = int.Parse(Console.ReadLine());

            double totalProfit = puzzels * 2.60 + dolls * 3 + teddyBears * 4.10 + minions*8.20 + tracks * 2;

            int toysQuantity = puzzels + dolls + teddyBears + minions + tracks;

            if (toysQuantity >= 50)
            {
               totalProfit = totalProfit - 0.25 * totalProfit;
               
            }
            totalProfit= totalProfit - totalProfit * 0.10;
           

            double diff = Math.Abs(totalProfit - holidayPrice);
            if (totalProfit >= holidayPrice)
            {
                Console.WriteLine($"Yes! {diff:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {diff:f2} lv needed.");
            }

        }
    }
}
