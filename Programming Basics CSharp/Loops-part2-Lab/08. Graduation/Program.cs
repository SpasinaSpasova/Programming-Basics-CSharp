using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double countGrade = 1; //за цикъла
            double sredenUspex = 0;
            double sum = 0;//събира оценките през тези 12 години
            while (countGrade <=12)
            {
                double currentGrade = double.Parse(Console.ReadLine());
                if (currentGrade >= 4.00)
                {
                    sum += currentGrade;
                    countGrade++;
                }
                else
                {
                    continue;
                }
                
            }
            sredenUspex = sum / 12;

            if (sredenUspex >= 4.00)
            {
                Console.WriteLine($"{name} graduated. Average grade: {sredenUspex:f2}");
            }

        }
    }
}
