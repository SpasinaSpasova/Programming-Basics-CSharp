using System;

namespace _08._HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string mesec = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studio = 0;
            double apartment = 0;
            if (mesec == "May" || mesec == "October")
            {
                studio = 50 * nights;
                apartment = 65 * nights;
                if (nights > 7 && nights <= 14)
                {
                    studio = studio - studio * 0.05; 
                    
                }
                else if (nights > 14)
                {
                    studio = studio - studio * 0.30;
                }
            }
            else if (mesec == "June" || mesec == "September")
            {
                studio = 75.20 * nights;
                apartment = 68.70 * nights;
                if (nights > 14)
                {
                    studio = studio - studio * 0.20;
                }
            }
            else if (mesec == "July" || mesec == "August")
            {
                studio = 76 * nights;
                apartment = 77* nights;
            }

            if (nights > 14)
            {
                apartment =apartment-apartment*0.1;
            }
            Console.WriteLine($"Apartment: {apartment:F2} lv.");
            Console.WriteLine($"Studio: {studio:F2} lv.");
        }
    }
}
