using System;

namespace _03._Cruise_Ship
{
    class Program
    {
        static void Main(string[] args)
        {
            string kruiz = Console.ReadLine();
            string kauta = Console.ReadLine();
            int noshtuvki = int.Parse(Console.ReadLine());
            double price = 0;

            switch (kauta)
            {
                case "standard cabin":
                    if (kruiz == "Mediterranean")
                    {
                        price = 27.50;
                    }
                    else if (kruiz == "Adriatic")
                    {
                        price = 22.99;
                    }
                    else if (kruiz == "Aegean")
                    {
                        price = 23.00;
                    }
                    break;

                case "cabin with balcony":
                    if (kruiz == "Mediterranean")
                    {
                        price = 30.20;
                    }
                    else if (kruiz == "Adriatic")
                    {
                        price = 25.00;
                    }
                    else if (kruiz == "Aegean")
                    {
                        price = 26.60;
                    }
                    break;

                case "apartment":
                    if (kruiz == "Mediterranean")
                    {
                        price = 40.50;
                    }
                    else if (kruiz == "Adriatic")
                    {
                        price = 34.99;
                    }
                    else if (kruiz == "Aegean")
                    {
                        price = 39.80;
                    }
                    break;
            }
            double sum = price * 4 * noshtuvki;
            if (noshtuvki>7)
            {
                sum = sum - sum * 0.25;
            }
            Console.WriteLine($"Annie's holiday in the {kruiz} sea costs {sum:f2} lv.");
        }
    }
}
