using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judgeCount = int.Parse(Console.ReadLine());

            string namePresentation = Console.ReadLine();

            double totalSum = 0;
            int countGrade = 0;

            while (namePresentation!="Finish")
            {
                double sum = 0;

                for (int judge = 1; judge <= judgeCount; judge++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sum += grade;
                    totalSum += grade;
                    countGrade++;
                }

                double avarage = sum / judgeCount;

                Console.WriteLine($"{namePresentation} - {avarage:f2}.");

                namePresentation = Console.ReadLine();
            }
            double totalAvarage = totalSum / countGrade;
            Console.WriteLine($"Student's final assessment is {totalAvarage:f2}.");
        }
    }
}
