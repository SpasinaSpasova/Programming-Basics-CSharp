using System;

namespace _10._Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string vidGodina = Console.ReadLine();
            int holidaysInYear = int.Parse(Console.ReadLine());
            int weekendsInYear = int.Parse(Console.ReadLine());

            double weekends =(48 - weekendsInYear)*(3.0/4);
            double holidays = holidaysInYear * (2.0/3);

            double totalGames = weekends + holidays + weekendsInYear;

            if (vidGodina == "leap")
            {
                totalGames =totalGames + 0.15 * totalGames;
                Console.WriteLine($"{Math.Floor(totalGames)}");
            }
            else if(vidGodina=="normal")
            {
                Console.WriteLine($"{Math.Floor(totalGames)}");
            }
            
        }
    }
}
