using System;

namespace AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double areaOfSquare = side * side;
                Console.WriteLine($"{areaOfSquare:f3}");
            }
            if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double areaOfRectangle = sideA * sideB;
                Console.WriteLine($"{areaOfRectangle:f3}");
            }
            if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double areaOfCircle = radius * radius * Math.PI;
                Console.WriteLine($"{areaOfCircle:f3}");
            }
            if (figure == "triangle")
            {
                double high = double.Parse(Console.ReadLine());
                double side = double.Parse(Console.ReadLine());
                double areaOfTriangle = side*high/2;
                Console.WriteLine($"{areaOfTriangle:f3}");
            }
        }
    }
}
