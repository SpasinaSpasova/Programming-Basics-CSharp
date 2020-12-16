using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;

            int i = 0;

            while (i<n)
            {
                int current = int.Parse(Console.ReadLine());

                if (current > maxNum)
                {
                    maxNum = current;
                }
                i++;
            }
            Console.WriteLine(maxNum);
        }
    }
}
