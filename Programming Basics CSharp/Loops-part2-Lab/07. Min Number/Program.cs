using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int minNum = int.MaxValue;

            int i = 0;

            while (i < n)
            {
                int current = int.Parse(Console.ReadLine());

                if (current < minNum)
                {
                    minNum = current;
                }
                i++;
            }
            Console.WriteLine(minNum);
        }
    }
}
