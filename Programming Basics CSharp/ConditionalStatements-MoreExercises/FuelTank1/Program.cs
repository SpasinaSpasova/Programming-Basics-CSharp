using System;

namespace FuelTank1
{
    class Program
    {
        static void Main(string[] args)
        {
            string gorivo = Console.ReadLine();
            double gorivoRezervoar = double.Parse(Console.ReadLine());

            if (gorivo == "Diesel")
            {
                if (gorivoRezervoar>=25)
                {
                    Console.WriteLine("You have enough diesel.");
                }
                else
                {
                    Console.WriteLine("Fill your tank with diesel!");
                }
            }
            else if(gorivo == "Gasoline")
            {
                if (gorivoRezervoar >= 25)
                {
                    Console.WriteLine("You have enough gasoline.");
                }
                else
                {
                    Console.WriteLine("Fill your tank with gasoline!");
                }
            }
            else if (gorivo == "Gas")
            {
                if (gorivoRezervoar >= 25)
                {
                    Console.WriteLine("You have enough gas.");
                }
                else
                {
                    Console.WriteLine("Fill your tank with gas!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }

        }
    }
}
