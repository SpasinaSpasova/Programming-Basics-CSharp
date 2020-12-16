using System;

namespace _04._Darts_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int osnovniTochki = int.Parse(Console.ReadLine());

            for (int count = 1; count <= osnovniTochki||osnovniTochki<=count; count++)
            {
                string mishena = Console.ReadLine();
                if (mishena == "bullseye")
                {
                    Console.WriteLine($"Congratulations! You won the game with a bullseye in {count} moves!");
                    break;
                }
                int tochki = int.Parse(Console.ReadLine());

                switch (mishena)
                {
                    case "number section":

                        osnovniTochki = osnovniTochki - tochki;

                        break;
                    case "double ring":

                        osnovniTochki = osnovniTochki - (2 * tochki);

                        break;
                    case "triple ring":

                        osnovniTochki = osnovniTochki - (3 * tochki);

                        break;
                       

                }
                
                if (osnovniTochki == 0)
                {
                    Console.WriteLine($"Congratulations! You won the game in {count} moves!");
                    break;
                }
                else if (osnovniTochki < 0)
                {
                    Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(osnovniTochki)}.");
                    break;
                }
                


            }
        }

    }
}