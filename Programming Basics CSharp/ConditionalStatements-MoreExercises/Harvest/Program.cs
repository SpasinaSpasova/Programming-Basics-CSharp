using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int ploshtLoze = int.Parse(Console.ReadLine());
            double kgGrozdeOtKvMetyr = double.Parse(Console.ReadLine());
            int nujniLitriVino = int.Parse(Console.ReadLine());
            int broiRabotnici = int.Parse(Console.ReadLine());

            double obshtoGrozde = ploshtLoze * kgGrozdeOtKvMetyr;
            double vino = (0.4 * obshtoGrozde) / 2.50;

            if (vino >= nujniLitriVino)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(vino)} liters.");
                Console.WriteLine($"{Math.Ceiling(vino - nujniLitriVino)} liters left -> {Math.Ceiling((vino - nujniLitriVino) / broiRabotnici)} liters per person.");

            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(nujniLitriVino - vino)} liters wine needed.");
            }
        }
    }
}
