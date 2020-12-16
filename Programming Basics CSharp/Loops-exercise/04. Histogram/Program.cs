using System;

namespace _04._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            int group4 = 0;
            int group5 = 0;

            for (int i = 1; i <= n; i++)
            {
                int current = int.Parse(Console.ReadLine());

                if (current < 200)
                {
                    group1++;
                }
                else if (current >= 200 && current <= 399)
                {
                    group2++;
                }
                else if (current >= 400 && current <= 599)
                {
                    group3++;
                }
                else if (current >= 600 && current <= 799)
                {
                    group4++;
                }
                else if (current >= 800)
                {
                    group5++;
                }
            }
            double persent1 = group1 * 1.0 / n * 100;
            double persent2 = group2 * 1.0 / n * 100;
            double persent3 = group3 * 1.0 / n * 100;
            double persent4 = group4 * 1.0 / n * 100;
            double persent5 = group5 * 1.0 / n * 100;

            Console.WriteLine($"{persent1:f2}%");
            Console.WriteLine($"{persent2:f2}%");
            Console.WriteLine($"{persent3:f2}%");
            Console.WriteLine($"{persent4:f2}%");
            Console.WriteLine($"{persent5:f2}%");
        }
    }
}
