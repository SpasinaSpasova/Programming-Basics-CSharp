using System;

namespace _02._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projekciq = Console.ReadLine();
            int redove = int.Parse(Console.ReadLine());
            int koloni = int.Parse(Console.ReadLine());

            double income = 0;

            if (projekciq == "Premiere")
            {
                income = redove * koloni * 12;
            }
            else if (projekciq == "Normal")
            {
                income = redove * koloni * 7.50;
            }
            else if (projekciq == "Discount")
            {
                income = redove * koloni * 5;
            }
           
            Console.WriteLine($"{income:f2} leva");

        }
    }
}
