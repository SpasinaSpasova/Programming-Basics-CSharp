using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fueltank2
{
    class Program
    {
        static void Main(string[] args)
        {
            string FuelType = Console.ReadLine();
            double Liters = double.Parse(Console.ReadLine());
            string DiscountCard = Console.ReadLine();
            double Price = 0;
            double Discount = 0;
            double Discount1 = 0;

            if (FuelType == "Gas")
            {
                if (DiscountCard == "Yes")
                {

                    Discount = 0.93 - 0.08;
                    if (Liters > 20 && Liters <= 25)
                    {
                        Discount1 = Discount * Liters;
                        Price = Discount1 - (Discount1 * 0.08);
                        Console.WriteLine($"{Price:F2} lv.");
                    }
                    else if (Liters > 25)
                    {
                        Discount1 = Discount * Liters;
                        Price = Discount1 - (Discount1 * 0.10);
                        Console.WriteLine($"{Price:F2} lv.");
                    }
                    else if (Liters < 20)
                    {
                        Discount1 = Discount * Liters;
                        Price = Discount1;
                        Console.WriteLine($"{Price:F2} lv.");
                    }
                }
                else if (DiscountCard == "No")
                {
                    if (Liters > 20 && Liters <= 25)
                    {

                        Discount1 = 0.93 * Liters;
                        Price = Discount1 - (Discount1 * 0.08);
                        Console.WriteLine($"{Price:F2} lv.");
                    }
                    else if (Liters > 25)
                    {
                        Discount1 = 0.93 * Liters;
                        Price = Discount1 - (Discount1 * 0.10);
                        Console.WriteLine($"{Price:F2} lv.");
                    }
                    else if (Liters < 20)
                    {
                        Discount1 = 0.93 * Liters;
                        Price = Discount1;
                        Console.WriteLine($"{Price:F2} lv.");
                    }

                }
            }
            else if (FuelType == "Gasoline")
            {
                if (DiscountCard == "Yes")
                {

                    Discount = 2.22 - 0.18;
                    if (Liters > 20 && Liters <= 25)
                    {

                        Discount1 = Discount * Liters;
                        Price = Discount1 - (Discount1 * 0.08);
                        Console.WriteLine($"{Price:F2} lv.");
                    }
                    else if (Liters > 25)
                    {
                        Discount1 = Discount * Liters;
                        Price = Discount1 - (Discount1 * 0.10);
                        Console.WriteLine($"{Price:F2} lv.");
                    }
                    else if (Liters < 20)
                    {
                        Discount1 = Discount * Liters;
                        Price = Discount1;
                        Console.WriteLine($"{Price:F2} lv.");
                    }
                }
                else if (DiscountCard == "No")
                {
                    if (Liters > 20 && Liters <= 25)
                    {

                        Discount1 = 2.22 * Liters;
                        Price = Discount1 - (Discount1 * 0.08);
                        Console.WriteLine($"{Price:F2} lv.");
                    }
                    else if (Liters > 25)
                    {
                        Discount1 = 2.22 * Liters;
                        Price = Discount1 - (Discount1 * 0.10);
                        Console.WriteLine($"{Price:F2} lv.");
                    }
                    else if (Liters < 20)
                    {
                        Discount1 = 2.22 * Liters;
                        Price = Discount1;
                        Console.WriteLine($"{Price:F2} lv.");
                    }

                }
            }
            else if (FuelType == "Diesel")
            {
                if (DiscountCard == "Yes")
                {

                    Discount = 2.33 - 0.12;
                    if (Liters > 20 && Liters <= 25)
                    {

                        Discount1 = Discount * Liters;
                        Price = Discount1 - (Discount1 * 0.08);
                        Console.WriteLine($"{Price:F2} lv.");
                    }
                    else if (Liters > 25)
                    {
                        Discount1 = Discount * Liters;
                        Price = Discount1 - (Discount1 * 0.10);
                        Console.WriteLine($"{Price:F2} lv.");
                    }
                    else if (Liters < 20)
                    {
                        Discount1 = Discount * Liters;
                        Price = Discount1;
                        Console.WriteLine($"{Price:F2} lv.");
                    }
                }
                else if (DiscountCard == "No")
                {
                    if (Liters > 20 && Liters <= 25)
                    {

                        Discount1 = 2.33 * Liters;
                        Price = Discount1 - (Discount1 * 0.08);
                        Console.WriteLine($"{Price:F2} lv.");
                    }
                    else if (Liters > 25)
                    {
                        Discount1 = 2.33 * Liters;
                        Price = Discount1 - (Discount1 * 0.10);
                        Console.WriteLine($"{Price:F2} lv.");
                    }
                    else if (Liters < 20)
                    {
                        Discount1 = 2.33 * Liters;
                        Price = Discount1;
                        Console.WriteLine($"{Price:F2} lv.");
                    }

                }
            }
        }
    }
}