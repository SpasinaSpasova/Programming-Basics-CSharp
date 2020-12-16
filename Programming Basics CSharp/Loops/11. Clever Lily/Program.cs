using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double pricePeralnq = double.Parse(Console.ReadLine());
            double priceIgrachka = double.Parse(Console.ReadLine());

            double moneyFromBdays = 0;
            double moneyGift = 10;

            int numOfToys = 0;

            for (int birthday = 1; birthday <=age; birthday++)
            {
                if (birthday % 2 == 0)
                {
                    moneyFromBdays += moneyGift;
                    moneyGift += 10;
                    moneyFromBdays -= 1;
                }
                else
                {
                    numOfToys += 1;
                }

            }

            double totalMoneyFromToys = numOfToys * priceIgrachka;

            double totalMoney = totalMoneyFromToys + moneyFromBdays;

            if (totalMoney >= pricePeralnq)
            {
                Console.WriteLine($"Yes! {totalMoney-pricePeralnq:f2}");
            }
            else
            {
                Console.WriteLine($"No! {pricePeralnq-totalMoney:f2}");
            }
        }
    }
}
