using System;
using System.Transactions;

namespace _07._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                int currentnumber = int.Parse(Console.ReadLine());
                sum += currentnumber;
            }
            Console.WriteLine(sum);
        }
    }
}
