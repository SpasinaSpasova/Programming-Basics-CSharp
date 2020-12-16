using System;

namespace _05._Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= n; k++)
                {
                    for (char q = 'a'; q <'a' + l; q++)
                    {
                        for (char j = 'a'; j < 'a' + l; j++)
                        {
                            for (int m = 1; m <= n; m++)
                            {
                                if (m > i && m > k)
                                {
                                    Console.Write($"{i}{k}{q}{j}{m} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
