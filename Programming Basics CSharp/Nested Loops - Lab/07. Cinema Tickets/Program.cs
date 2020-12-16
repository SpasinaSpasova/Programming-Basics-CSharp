using System;

class Program
{
    static void Main(string[] args)
    {
        string movieName = Console.ReadLine();

        int totalTicketsCount = 0;
        int kidTicketsCount = 0;
        int studentTicketsCount = 0;
        int standardTicketsCount = 0;


        while (movieName != "Finish")
        {
            int seatsAvailable = int.Parse(Console.ReadLine());

            string ticket = Console.ReadLine();
            int ticketsCounter = 0;

            while (ticket != "End")
            {
                switch (ticket)
                {
                    case "kid":
                        kidTicketsCount++;
                        break;
                    case "standard":
                        standardTicketsCount++;
                        break;
                    case "student":
                        studentTicketsCount++;
                        break;
                }

                ticketsCounter++;

                if (ticketsCounter == seatsAvailable)
                {
                    break;
                }

                ticket = Console.ReadLine();
            }

            totalTicketsCount += ticketsCounter;

            double seatsTaken = ticketsCounter * 1.0 / seatsAvailable * 100;
            Console.WriteLine($"{movieName} - {seatsTaken:f2}% full.");

            movieName = Console.ReadLine();
        }


        double kidTicketsPercent = kidTicketsCount * 1.0 / totalTicketsCount * 100;
        double standardTicketsPercent = standardTicketsCount * 1.0 / totalTicketsCount * 100;
        double studentTicketsPercent = studentTicketsCount * 1.0 / totalTicketsCount * 100;


        Console.WriteLine($"Total tickets: {totalTicketsCount}");
        Console.WriteLine($"{studentTicketsPercent:f2}% student tickets.");
        Console.WriteLine($"{standardTicketsPercent:f2}% standard tickets.");
        Console.WriteLine($"{kidTicketsPercent:f2}% kids tickets.");

    }

}
