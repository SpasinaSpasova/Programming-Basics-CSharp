using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int neobhodimiChasove = int.Parse(Console.ReadLine());
            int dniNaRazpolojenie = int.Parse(Console.ReadLine());
            int broiSlujiteli = int.Parse(Console.ReadLine());

            double chasoveRabota = (dniNaRazpolojenie - 0.1 * dniNaRazpolojenie) * 8;

            int rabotaIzvynredno = broiSlujiteli * (dniNaRazpolojenie * 2);

            double sumChasove = Math.Floor(chasoveRabota + rabotaIzvynredno);

            if (sumChasove >= neobhodimiChasove)
            {
                double ostavashtiChasove = sumChasove - neobhodimiChasove;
                Console.WriteLine($"Yes!{ ostavashtiChasove} hours left.");
            }
            else
            {
                double nedostigashtiChasove = neobhodimiChasove - sumChasove;
                Console.WriteLine($"Not enough time!{nedostigashtiChasove} hours needed.");
            }
        }
    }
}
