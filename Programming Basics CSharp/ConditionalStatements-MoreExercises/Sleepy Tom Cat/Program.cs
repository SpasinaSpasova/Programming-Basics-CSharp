using System;

namespace Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int pochivniDni = int.Parse(Console.ReadLine());

            int rabotniDni = 365 - pochivniDni;
            int vremeZaIgra = rabotniDni * 63 + pochivniDni * 127;

           

            if (30000 > vremeZaIgra)
            {
               
                
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{(30000-vremeZaIgra)/60} hours and {(30000 - vremeZaIgra)%60} minutes less for play");
            }
            else
            {
                
                
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{(vremeZaIgra-30000) / 60} hours and {(vremeZaIgra-30000)%60} minutes more for play");   
            }
        }
    }
}
