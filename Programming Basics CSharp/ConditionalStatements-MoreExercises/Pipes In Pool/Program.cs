using System;

namespace Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2= int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double sumP1 = P1 * H;
            double sumP2 = P2 * H;

            double sumP1P2 = sumP1 + sumP2;
            if (sumP1P2 <= V)
            {
                double fullPool = (sumP1P2 / V)*100;
                double tryba1 = (sumP1 / sumP1P2) * 100;
                double tryba2 = (sumP2 / sumP1P2) * 100;
                Console.WriteLine($"The pool is {fullPool}% full. Pipe 1: {tryba1:f2}%. Pipe 2: {tryba2:f2}%.");
            }
            else
            {
                double litriPoveche = sumP1P2 - V;
                Console.WriteLine($"For {H} hours the pool overflows with {litriPoveche:f2} liters.");
            }
        }
    }
}
