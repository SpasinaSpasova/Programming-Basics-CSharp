using System;

namespace _03._SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradusi = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string outfit = "";
            string shoes = "";

            if (gradusi >= 10 && gradusi <= 18)
            {
                if (timeOfDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (timeOfDay == "Afternoon" || timeOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (gradusi > 18 && gradusi <= 24)
            {
                if (timeOfDay == "Morning" || timeOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (gradusi >= 25)
            {
                if (timeOfDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (timeOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {gradusi} degrees, get your {outfit} and {shoes}.");
        }
    }
}
