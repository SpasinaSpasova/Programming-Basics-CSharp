using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int broiDni = int.Parse(Console.ReadLine());
            
            int ostavenaHranaKg = int.Parse(Console.ReadLine());
            
            double hranaNaDenKucheKg = double.Parse(Console.ReadLine());
            
            double hranaNaDenKotkaKg = double.Parse(Console.ReadLine());
            
            double hranaNaDenKostenurkaGr = double.Parse(Console.ReadLine());

            double nujnaHranaKuche = broiDni * hranaNaDenKucheKg;
            double nujnaHranaKotka = broiDni * hranaNaDenKotkaKg;
            double nujnaHranaKostenurka = (broiDni * hranaNaDenKostenurkaGr)/1000;

            double sumHrana = nujnaHranaKostenurka + nujnaHranaKotka + nujnaHranaKuche;

            if (sumHrana <= ostavenaHranaKg)
            {
                double kgOstatyk = Math.Floor(ostavenaHranaKg-sumHrana);
                Console.WriteLine($"{ kgOstatyk} kilos of food left.");
            }
            else
            {
                double kgNedostig = Math.Ceiling(sumHrana-ostavenaHranaKg);
                Console.WriteLine($"{kgNedostig} more kilos of food are needed.");
            }
        }
    }
}
