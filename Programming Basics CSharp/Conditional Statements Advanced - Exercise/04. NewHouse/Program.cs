using System;

namespace _04._NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string cvete = Console.ReadLine();
            int broi = int.Parse(Console.ReadLine());
            int budjet = int.Parse(Console.ReadLine());

            double price = 0;
            //- "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"

            //  	5	3.80	2.80	3	2.50

            //•	Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 90  Далии - 15 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            //•	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            //•	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %

            if (cvete == "Roses")
            {
                if (broi > 80)
                {
                    price = (5 - 5 * 0.1) * broi;
                }
                else
                {
                    price = 5 * broi;
                }
            }
            else if (cvete == "Dahlias")
            {
                if (broi > 90)
                {
                    price = (3.80 - 3.80 * 0.15) * broi;
                }
                else
                {
                    price = 3.80 * broi;
                }
            }
           else if (cvete == "Tulips")
            {
                if (broi > 80)
                {
                    price = (2.80 - 2.80 * 0.15) * broi;
                }
                else
                {
                    price = 2.80 * broi;
                }
            }
           else if (cvete == "Narcissus")
            {
                if (broi <120)
                {
                    price = (3 + 3 * 0.15) * broi;
                }
                else
                {
                    price = 3 * broi;
                }
            }
            else if (cvete == "Gladiolus")
            {
                if (broi <80)
                {
                    price = (2.50 + 2.50 * 0.20) * broi;
                }
                else
                {
                    price = 2.50 * broi;
                }
            }

            if (price <= budjet)
            {
                double left = budjet - price;
                Console.WriteLine($"Hey, you have a great garden with {broi} {cvete} and {left:f2} leva left.");
            }
            else
            {
                double need = price - budjet;
                Console.WriteLine($"Not enough money, you need {need:f2} leva more.");
            }
        }
    }
}
