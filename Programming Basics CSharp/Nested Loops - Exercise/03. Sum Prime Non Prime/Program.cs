using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();

            int sumPrime = 0;
            int sumNoPrime = 0;

            while (num1 != "stop")
            {
                int current = int.Parse(num1);

                if (current<0)
                {
                    Console.WriteLine("Number is negative.");
                    num1 = Console.ReadLine();
                    continue;
                }

                int count = 0;

                for (int i = 1; i <= current; i++)
                {
                    if (current % i == 0)
                    {
                        count++;
                    }
                }

                if (count==2)
                {
                    sumPrime += current;
                }
                else if(count>2)
                {
                    sumNoPrime += current;
                }


                num1 = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNoPrime}");
        }
    }
}
