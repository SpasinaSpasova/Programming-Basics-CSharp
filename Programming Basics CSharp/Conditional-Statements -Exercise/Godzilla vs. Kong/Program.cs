using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countStatists = int.Parse(Console.ReadLine());
            double pricePerStatist = double.Parse(Console.ReadLine());

            double decor = 0.10 * budget;
            double clothes = countStatists * pricePerStatist;

            if (countStatists > 150)
            {
                clothes = clothes - 0.10 * clothes; 
            }

            double expenses = decor + clothes;

            if (budget >= expenses)
            {
                Console.WriteLine("Action!");
                double leftMoney = budget - expenses;
                Console.WriteLine($"Wingard starts filming with {leftMoney:F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                double needMoney = expenses - budget;
                Console.WriteLine($"Wingard needs {needMoney:F2} leva more.");
            }

        }
    }
}
