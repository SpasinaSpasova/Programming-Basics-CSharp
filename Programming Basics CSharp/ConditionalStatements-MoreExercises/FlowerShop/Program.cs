using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiMagnolii = int.Parse(Console.ReadLine());
           
            int broiZumbuli = int.Parse(Console.ReadLine());
          
            int broiRozi = int.Parse(Console.ReadLine());
            
            int broiKaktusi = int.Parse(Console.ReadLine());
            
            double giftPrice = double.Parse(Console.ReadLine());

            double sum = broiMagnolii * 3.25 + broiZumbuli * 4 + broiRozi * 3.50 + broiKaktusi * 8;

            double danyk = sum - 0.05 * sum;
            Console.WriteLine(danyk);
            
            if(giftPrice> danyk)
            {
                double nedostig = Math.Ceiling(giftPrice - danyk);
                Console.WriteLine($"She will have to borrow {nedostig} leva.");
            }
            else
            {
                double ostatyk = Math.Floor(danyk - giftPrice);
                Console.WriteLine($"She is left with {ostatyk} leva.");
            }

        }
    }
}
