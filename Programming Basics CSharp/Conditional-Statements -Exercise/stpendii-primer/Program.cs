using System;

namespace stpendii_primer
{
    class Program
    {
        static void Main(string[] args)
        {
            double dohod = double.Parse(Console.ReadLine());
            double sredenUspeh = double.Parse(Console.ReadLine());
            double minimalnaRabotnaZaplata = double.Parse(Console.ReadLine());

            double socialnaStipendiq = Math.Floor(minimalnaRabotnaZaplata * 0.35);
            double stipendiqUspeh = Math.Floor(sredenUspeh * 25);

            if (sredenUspeh >= 5.5)
            {
                if (stipendiqUspeh >= socialnaStipendiq || dohod > minimalnaRabotnaZaplata)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {stipendiqUspeh} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a Social scholarship {socialnaStipendiq} BGN");
                }
            }
            else if (sredenUspeh > 4.5 && dohod < minimalnaRabotnaZaplata)
            {
                Console.WriteLine($"You get a Social scholarship {socialnaStipendiq} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
