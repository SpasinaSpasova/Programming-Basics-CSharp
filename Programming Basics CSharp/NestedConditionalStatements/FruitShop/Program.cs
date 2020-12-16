using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {

            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;


            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    //banana	apple	orange	grapefruit	kiwi	pineapple	grapes
                    //2.50	   1.20   	0.85	  1.45	    2.70   	5.50    	3.85
                    case "banana":
                        price = 2.50;
                        break;
                    case "apple":
                        price = 1.20;
                        break;
                    case "orange":
                        price = 0.85;
                        break;
                    case "grapefruit":
                        price = 1.45;
                        break;
                    case "kiwi":
                        price = 2.70;
                        break;
                    case "pineapple":
                        price = 5.50;
                        break;
                    case "grapes":
                        price = 3.85;
                        break;
                }
            }
            else if (day == "Sunday" || day == "Saturday")
            {
                switch (fruit)
                {
                    //2.70	1.25	0.90	1.60	3.00	5.60	4.20
                    case "banana":
                        price = 2.70;
                        break;
                    case "apple":
                        price = 1.25;
                        break;
                    case "orange":
                        price = 0.90;
                        break;
                    case "grapefruit":
                        price = 1.60;
                        break;
                    case "kiwi":
                        price = 3.00;
                        break;
                    case "pineapple":
                        price = 5.60;
                        break;
                    case "grapes":
                        price = 4.20;
                        break;
                }
            }

            if (price > 0)
            {
                Console.WriteLine($"{(price * quantity):f2}");
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
