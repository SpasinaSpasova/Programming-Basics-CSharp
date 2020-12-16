using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();



            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double money = double.Parse(Console.ReadLine());
                double sum = money;
                while (sum < budget)
                {
                    money = double.Parse(Console.ReadLine());
                    sum += money;

                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();

            }
        }
    }
}
