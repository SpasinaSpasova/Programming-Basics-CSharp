using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometri = int.Parse(Console.ReadLine());
            string chastNaDenq = Console.ReadLine();

            double tarifaDayTaxi = 0.7 + (0.79 * kilometri);
            double tarifaNightTaxi = 0.7 +( 0.9 * kilometri);

            double tarifaAvtobus = 0.09 * kilometri;

            double tarifaVlak = 0.06 * kilometri;

            if (kilometri< 20 && chastNaDenq == "day")
            {
                Console.WriteLine($"{tarifaDayTaxi:f2}");
            }
            else if (kilometri< 20 && chastNaDenq == "night")
            {
                Console.WriteLine($"{tarifaNightTaxi:f2}");
            }
            else if (kilometri >= 100)
            {
                Console.WriteLine($"{tarifaVlak:f2}");
            }
            else if (kilometri>=20)
            {
                Console.WriteLine($"{tarifaAvtobus:f2}");
            }

        }
    }
}
