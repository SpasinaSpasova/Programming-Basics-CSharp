using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiVnoski = int.Parse(Console.ReadLine());

            int i = 0;
            double bankAccount = 0;

            while (i != broiVnoski)
            {
                double money = double.Parse(Console.ReadLine());

                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
 
                bankAccount += money;
                Console.WriteLine($"Increase: {money:f2}");
               
                i++;

            }

            Console.WriteLine($"Total: {bankAccount:f2}");
        }
    }
}
