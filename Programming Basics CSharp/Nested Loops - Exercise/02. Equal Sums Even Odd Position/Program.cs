using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

           

            for (int i = n1; i <= n2; i++)
            {
                string currentNum = i.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for (int k = 0; k < currentNum.Length; k++)
                {
                    int currentDigit = int.Parse(currentNum[k].ToString());
                    if (k%2==0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }

            }
        }
    }
}
