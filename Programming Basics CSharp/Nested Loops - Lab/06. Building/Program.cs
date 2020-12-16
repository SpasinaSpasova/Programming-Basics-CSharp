using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiEtaji = int.Parse(Console.ReadLine());
            int broiStaiNaEdinEtaj = int.Parse(Console.ReadLine());

            
            for (int i = broiEtaji; i >=1; i--)
            {
                for (int k = 0; k < broiStaiNaEdinEtaj; k++)
                {
                    
                     
                    if (i==broiEtaji)
                    {
                        Console.Write($"L{i}{k} ");
                    }

                    else if (i%2==0)
                    {
                        Console.Write($"O{i}{k} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{k} ");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
