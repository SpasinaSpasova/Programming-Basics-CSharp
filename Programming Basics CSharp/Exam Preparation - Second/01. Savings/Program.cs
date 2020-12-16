using System;

namespace _01._Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double dohod = double.Parse(Console.ReadLine());
            int meseci = int.Parse(Console.ReadLine());
            double neobhodimaSuma= double.Parse(Console.ReadLine());

            double lichniDohodi = 0.3 * dohod;

            double sumMesec = dohod - (neobhodimaSuma + lichniDohodi);

            double vsichkiMeseci = meseci * sumMesec;

            double percent = sumMesec / dohod*100;

            Console.WriteLine($"She can save {percent:f2}%");
            Console.WriteLine($"{vsichkiMeseci:f2}");

        }
    }
}
