using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double sumEvenPos = 0;
            double sumOddPos = 0;
            for (int i = 1; i <= number; i++)
            {
                int position = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEvenPos += position;
                }
                else
                {
                    sumOddPos += position;
                }
            }C:\Users\DELL\source\repos\Loops\10. Odd Even Sum\Program.cs
            if (sumEvenPos==sumOddPos)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sumEvenPos);
            }
            else
            {
                double diff = Math.Abs(sumEvenPos - sumOddPos);
                Console.WriteLine("No"); 
                Console.WriteLine("Diff = " + diff); 

            }
            
        }
    }
}
