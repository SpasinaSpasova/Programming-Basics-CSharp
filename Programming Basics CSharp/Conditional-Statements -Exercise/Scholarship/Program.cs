using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double Dohod = double.Parse(Console.ReadLine());
            double sredenUspeh= double.Parse(Console.ReadLine());
            double minimalnaRabotnaZaplata= double.Parse(Console.ReadLine());

            double socialnaStipendiq = Math.Floor(0.35 * minimalnaRabotnaZaplata);
            double stipendiqUspeh = Math.Floor(sredenUspeh * 25);
            
            if(sredenUspeh>=5.50)
            {
                if(stipendiqUspeh>=socialnaStipendiq && sredenUspeh >= 5.50)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {stipendiqUspeh} BGN");
                }
                else if (stipendiqUspeh <= socialnaStipendiq && sredenUspeh <= 5.50)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {stipendiqUspeh} BGN");
                }
            }
            else if (sredenUspeh >= 4.50 && Dohod < minimalnaRabotnaZaplata)
            {
                Console.WriteLine($"You get a Social scholarship { socialnaStipendiq} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
      
        }
    }
}

