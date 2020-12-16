using System;

namespace ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int sum = 0;
            while (text!="Stop")
            {
                sum++;
                text = Console.ReadLine();
            }
            Console.WriteLine(sum);

            
        }
    }
}
