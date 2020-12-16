using System;

namespace _05._Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int group1 = 0;
            int group2 = 0;
            int group3 = 0;

            for (int i = 1; i <= n; i++)
            {
                int current = int.Parse(Console.ReadLine());

                if (current % 2 == 0)
                {
                    group1++;
                }
                if (current % 3 == 0)
                {
                    group2++;
                }
                if (current % 4 == 0)
                {
                    group3++;
                }
            }
            double persent1 = group1*1.0/ n * 100;
            double persent2= group2*1.0/n  * 100;
            double persent3= group3*1.0/ n * 100;

            Console.WriteLine($"{persent1:f2}%");
            Console.WriteLine($"{persent2:f2}%");
            Console.WriteLine($"{persent3:f2}%");
        }
    }
}
