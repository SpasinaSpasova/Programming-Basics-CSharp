using System;
using System.Runtime.Serialization;

namespace _06._Baking_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int uchastnici = int.Parse(Console.ReadLine());

            double sum = 0;

            int cookies1 = 0;
            int cakes1 = 0;
            int waffles1 = 0;

            for (int i = 1; i <= uchastnici; i++)
            {
                string name = Console.ReadLine();
                string vidSladkish = Console.ReadLine();
                int broiSladkishiOtVid = int.Parse(Console.ReadLine());
                int cookies = 0;
                int cakes = 0;
                int waffles = 0;



                while (vidSladkish != "Stop baking!")
                {
                   

                    if (vidSladkish == "cookies")
                    {
                        cookies += broiSladkishiOtVid;
                        sum += broiSladkishiOtVid;
                        cookies1 += broiSladkishiOtVid;

                    }
                    else if (vidSladkish == "cakes")
                    {
                        cakes += broiSladkishiOtVid;
                        sum += broiSladkishiOtVid;
                        cakes1 += broiSladkishiOtVid;
                    }
                    else if (vidSladkish == "waffles")
                    {
                        waffles += broiSladkishiOtVid;
                        sum += broiSladkishiOtVid;
                        waffles1 += broiSladkishiOtVid;

                    }

                    vidSladkish = Console.ReadLine();

                    if (vidSladkish=="Stop baking!")
                    {
                        break;
                    }
                    else
                    {
                        broiSladkishiOtVid = int.Parse(Console.ReadLine());
                    }

                    
                }
                Console.WriteLine($"{name} baked {cookies} cookies, {cakes} cakes and {waffles} waffles.");
            }
            Console.WriteLine($"All bakery sold: {sum}");

            double price1 = cookies1 * 1.50;
            double price2 = cakes1 * 7.80;
            double price3 = waffles1 * 2.30;
            //сладки - 1,50, торти - 7,80, гофрети - 2,30,  
            Console.WriteLine($"Total sum for charity: {(price1+price2+price3):f2} lv.");
        }
    }
}
