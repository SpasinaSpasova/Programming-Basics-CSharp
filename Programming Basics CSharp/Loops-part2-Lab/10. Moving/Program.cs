using System;

namespace _10._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int shirochina = int.Parse(Console.ReadLine());
            int dyljina = int.Parse(Console.ReadLine());
            int visochina = int.Parse(Console.ReadLine());

           string broiKashoni = Console.ReadLine();

            int svobodnoMqsto = shirochina * dyljina * visochina;

           
            while (broiKashoni != "Done")
            {
                svobodnoMqsto -= int.Parse(broiKashoni);

                if (svobodnoMqsto < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(svobodnoMqsto)} Cubic meters more.");
                    break;
                }
                
                broiKashoni = Console.ReadLine();
            }
            if (broiKashoni == "Done")
            {
                Console.WriteLine($"{Math.Abs(svobodnoMqsto)} Cubic meters left.");
                
            }
        }
    }
}
