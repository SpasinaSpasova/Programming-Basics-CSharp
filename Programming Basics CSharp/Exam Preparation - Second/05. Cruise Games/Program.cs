using System;

namespace _05._Cruise_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int igri =int.Parse( Console.ReadLine());

            
            int count = 1;

            int countVol = 0;
            int countTen = 0;
            int countBad = 0;

            double tochkiVol = 0;
            double tochkiTen = 0;
            double tochkiBad = 0;

            double sum = 0;

            while (count <= igri)
            {
                string nameGame = Console.ReadLine();
                double tochki = double.Parse(Console.ReadLine());

                count++;
                switch (nameGame)
                {
                    case "volleyball":
                        countVol++;
                        tochkiVol += tochki+ tochki * 0.07;
                        
                        break;
                    case "tennis":
                        countTen++;
                        tochkiTen += tochki+tochki * 0.05;
                        
                        break;
                    case "badminton":
                        countBad++;
                        tochkiBad += tochki+ tochki * 0.02;
                        
                        break;
                }
                

            }
            sum = tochkiVol + tochkiTen + tochkiBad;

            tochkiVol = (tochkiVol / countVol);
            tochkiTen = (tochkiTen / countTen);
            tochkiBad = (tochkiBad / countBad);

                

            bool uspeshno = tochkiVol >= 75 && tochkiTen >= 75 && tochkiBad >= 75;

            if (uspeshno)
            {
                Console.WriteLine($"Congratulations, {name}! You won the cruise games with {Math.Floor(sum)} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {name}, you lost. Your points are only {Math.Floor(sum)}.");
            }
        }
    }
}
