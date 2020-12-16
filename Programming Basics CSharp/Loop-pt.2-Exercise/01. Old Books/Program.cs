using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int numOfBook = int.Parse(Console.ReadLine());

            int countOfSearched = 0;

            while (numOfBook>0)
            {
                string input = Console.ReadLine();
                if (input == bookName)
                {
                    Console.WriteLine($"You checked {countOfSearched} books and found it.");
                    break;
                }
                else
                {
                    countOfSearched++;
                   
                }
                numOfBook--;
            }
            if (numOfBook <= 0)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {countOfSearched} books.");
            }
        }
    }
}
