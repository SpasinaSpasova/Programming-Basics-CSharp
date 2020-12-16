using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            double haveMoney = double.Parse(Console.ReadLine());

            int countSpendDays = 0;
            int countTotalDays = 0;

            while (haveMoney<tripPrice)
            {
                string action = Console.ReadLine();
                double price= double.Parse(Console.ReadLine());

                countTotalDays++;

                if (action == "save")
                {
                   
                    haveMoney += price;
                    countSpendDays = 0;
                }
                else if(action == "spend")
                {
                   
                    countSpendDays++;
                    haveMoney -= price;
                    if (haveMoney < 0)
                    {
                        haveMoney = 0;
                    }
                }

                if (countSpendDays == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(countTotalDays);
                    break;
                }
            }
            if (haveMoney >= tripPrice)
            {
                Console.WriteLine($"You saved the money for {countTotalDays} days.");
            }


        }
    }
}
