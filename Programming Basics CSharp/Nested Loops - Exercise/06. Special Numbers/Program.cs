using System;

namespace _06._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int q = 1; q <= 9; q++)
                        {
                            bool chek1 = i != 0 && N % i == 0;
                            bool chek2 = j != 0 && N % j == 0;
                            bool chek3 = k != 0 && N % k == 0;
                            bool chek4 = q != 0 && N % q == 0;

                            if (chek1&&chek2&&chek3&&chek4)
                            {
                                Console.Write($"{i}{j}{k}{q} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
