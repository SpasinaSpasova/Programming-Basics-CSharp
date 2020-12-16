using System;
using System.Runtime.Serialization;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int magicnum= int.Parse(Console.ReadLine());

            
            int count = 0;
           

            for (int i = n1; i <= n2; i++)
            {
                for (int k = n1; k <= n2; k++)
                {
                    int sum = i + k;
                    count++;
                    if (sum==magicnum)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {k} = {magicnum})");
                        return;
                    }
                    
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicnum}");

        }
    }
}
