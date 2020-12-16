using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int shirochina = int.Parse(Console.ReadLine());
            int dyljina = int.Parse(Console.ReadLine());

            int razmerTorta = shirochina * dyljina;
            
       
            while (razmerTorta > 0)
            {
                string komanda = Console.ReadLine();

                if (komanda == "STOP")
                {
                    Console.WriteLine($"{razmerTorta} pieces are left.");
                    break;
                }
                else
                {
                    int parcheta = int.Parse(komanda);
                    
                    razmerTorta -= parcheta;
                }
                
            }

            if (razmerTorta < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(razmerTorta)} pieces more.");
            }



        }
    }
}
