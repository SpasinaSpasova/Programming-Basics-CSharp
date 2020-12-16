using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int sum = 0;
            
            while (number!="Stop")
            {
                int current = int.Parse(number);
                sum += current;
                number = Console.ReadLine();
            }
            Console.WriteLine(sum);
        }
    }
}
