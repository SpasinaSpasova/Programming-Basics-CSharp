using System;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int chas = int.Parse(Console.ReadLine());
            int minuti = int.Parse(Console.ReadLine());
            int timeAfter15Minutes = (chas*60)+minuti + 15;
            int resultChas = timeAfter15Minutes / 60;

            if (resultChas >= 24)
            {
                resultChas-=24;
            }
            int resultMinuti = timeAfter15Minutes % 60;
            if (resultMinuti< 10)
            {
                Console.WriteLine(resultChas + ":0" + resultMinuti);
            }

            else
            {
                Console.WriteLine($"{resultChas}:{resultMinuti}");
            }
        }
    }
}
