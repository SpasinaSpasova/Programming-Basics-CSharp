using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double prodajbi = double.Parse(Console.ReadLine());
            double comisionna = 0;

            //          0 ≤ s ≤ 500	   500 < s ≤ 1 000	  1 000 < s ≤ 10 000	   s > 10 000
            // Sofia      5 %                7 %                  8 %              12 %
            //  Varna     4.5 %               7.5%              10 %             13 %
            // Plovdiv     5.5 %               8 %                12 %              14.5 %
            if (town == "Sofia")
            {
                if (0 <= prodajbi && prodajbi <= 500)
                {
                    comisionna = prodajbi * 0.05;
                }
                else if (500 < prodajbi && prodajbi <= 1000)
                {
                    comisionna = prodajbi * 0.07;
                }
                else if (1000 < prodajbi && prodajbi <= 10000)
                {
                    comisionna = prodajbi * 0.08;
                }
                else if (prodajbi > 10000)
                {
                    comisionna = prodajbi * 0.12;
                }
            }
            else if (town == "Varna")
            {
                if (0 <= prodajbi && prodajbi <= 500)
                {
                    comisionna = prodajbi * 0.045;
                }
                else if (500 < prodajbi && prodajbi <= 1000)
                {
                    comisionna = prodajbi * 0.075;
                }
                else if (1000 < prodajbi && prodajbi <= 10000)
                {
                    comisionna = prodajbi * 0.1;
                }
                else if (prodajbi > 10000)
                {
                    comisionna = prodajbi * 0.13;
                }
            }
            else if (town == "Plovdiv")
            {
                if (0 <= prodajbi && prodajbi <= 500)
                {
                    comisionna = prodajbi * 0.055;
                }
                else if (500 < prodajbi && prodajbi <= 1000)
                {
                    comisionna = prodajbi * 0.08;
                }
                else if (1000 < prodajbi && prodajbi <= 10000)
                {
                    comisionna = prodajbi * 0.12;
                }
                else if (prodajbi > 10000)
                {
                    comisionna = prodajbi * 0.145;
                }
            }
            if (comisionna != 0)
            {
                Console.WriteLine($"{comisionna:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
