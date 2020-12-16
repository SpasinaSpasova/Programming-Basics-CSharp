﻿using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            int max = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                sum+= current;

                if (current > max)
                {
                    max=current;
                }
               
            }

            int total = sum - max;
            if (max== total)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int diff = Math.Abs(max-total);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
           
        }
    }
}
