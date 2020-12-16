using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double restoLeva = double.Parse(Console.ReadLine());
            double resto = Math.Round(restoLeva * 100);
            int count = 0;

            while (resto != 0)
            {
                if (resto >= 200)
                {
                    resto -= 200;
                    count++;
                }
                else if (resto >= 100)
                {
                    resto -= 100;
                    count++;
                }
                else if (resto >= 50)
                {
                    resto -= 50;
                    count++;
                }
                else if (resto >= 20)
                {
                    resto -= 20;
                    count++;
                }
                else if (resto >= 10)
                {
                    resto -= 10;
                    count++;
                }
                else if (resto >= 5)
                {
                    resto -= 5;
                    count++;
                }
                else if (resto >= 5)
                {
                    resto -= 5;
                    count++;
                }
                else if (resto >= 2)
                {
                    resto -= 2;
                    count++;
                }
                else if (resto >= 1)
                {
                    resto -= 1;
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
