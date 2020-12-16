using System;

namespace _02._Summer_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int budjet = int.Parse(Console.ReadLine());

            double plajnaHavliq= double.Parse(Console.ReadLine());

            double otstypka= double.Parse(Console.ReadLine());

            
            double chadyr = (2*1.0 / 3 )* plajnaHavliq;
            double djapanki = 0.75 * chadyr;
            double plajnaChanta = (1 * 1.0 / 3) * (plajnaHavliq + djapanki);

            double sum = plajnaHavliq + chadyr + djapanki + plajnaChanta;

            double discount = sum-sum * otstypka/100;
            if (budjet>=discount)
            {
                Console.WriteLine($"Annie's sum is {discount:f2} lv. She has {budjet-discount:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {discount:f2} lv. She needs {discount-budjet:F2} lv. more.");
            }
        }
    }
}
