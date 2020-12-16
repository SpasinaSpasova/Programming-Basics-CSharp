using System;
using System.Security.Cryptography;
using System.Transactions;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double left = 0;
            double right = 0;
            for (int i = 1; i <= n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                left += current;
            }
            for (int j = 1; j <=n; j++)
            {
                int current2 = int.Parse(Console.ReadLine());
                right += current2;
            }
            if (left == right)
                {
                    Console.WriteLine(" Yes, sum = " + left);
                }
            else
            {
                double diff = Math.Abs(right - left);
                Console.WriteLine("No, diff = " + diff);
            }
        }

    }
}
