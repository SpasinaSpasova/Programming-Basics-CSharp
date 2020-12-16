using System;

namespace _05._FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budjet = int.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();
            int broi = int.Parse(Console.ReadLine());

            double naem = 0;
            //Цената за наем на кораба през пролетта е  3000 лв.
            //Цената за наем на кораба през лятото и есента е  4200 лв.
            //Цената за наем на кораба през зимата е  2600 лв.
            if (sezon == "Spring")
            {
                if (broi <= 6)
                {
                    naem = 3000 - 3000 * 0.10;
                }
                else if (broi > 7 && broi <= 11)
                {
                    naem = 3000 - 3000 * 0.15;
                }
                else if (broi > 12)
                {
                    naem = 3000 - 3000 * 0.25;
                }
            }
            else if (sezon == "Summer" || sezon == "Autumn")
            {
                if (broi <= 6)
                {
                    naem = 4200 - 4200 * 0.10;
                }
                else if (broi > 7 && broi <= 11)
                {
                    naem = 4200 - 4200 * 0.15;
                }
                else if (broi > 12)
                {
                    naem = 4200 - 4200 * 0.25;
                }
            }
            else if (sezon == "Winter")
            {
                if (broi <= 6)
                {
                    naem = 2600 - 2600 * 0.10;
                }
                else if (broi > 7 && broi <= 11)
                {
                    naem = 2600 - 2600 * 0.15;
                }
                else if (broi > 12)
                {
                    naem = 2600 - 2600 * 0.25;
                }
            }
            if (sezon != "Autumn" && broi % 2 == 0)
            {
                naem -= naem * 0.05;
            }


            double money = Math.Abs(naem - budjet);

            if (naem > budjet)
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", money);
            }
            else if (budjet >= naem)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", money);
            }


            //•	Ако групата е до 6 човека включително  –  отстъпка от 10 %.
            //•	Ако групата е от 7 до 11 човека включително  –  отстъпка от 15 %.
            //•	Ако групата е от 12 нагоре  –  отстъпка от 25 %.

        }
    }
}
