using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първи ред -дни за престой -цяло число в интервала[0...365]
            int days = int.Parse(Console.ReadLine());
            //Втори ред -вид помещение - "room  for  one  person", "apartment" или "president  apartment"
            string room = Console.ReadLine();
            //Трети ред -оценка - "positive"  или "negative"
            string feedback = Console.ReadLine();

            //"room for one person" – 18.00 лв за нощувка
            double roomForOne = 18.00 * (days - 1);
            //"apartment" – 25.00 лв за нощувка
            double apartment = 25.00 * (days - 1);
            //"president apartment" – 35.00 лв за нощувка
            double presidentApartment = 35.00 * (days - 1);

            //вид помещение         по - малко от 10 дни       между 10 и 15 дни       повече от 15 дни
            //room for one person   не ползва намаление        не ползва намаление      не ползва намаление
            //apartment             30 % от крайната цена    35 % от крайната цена    50 % от крайната цена
            //president apartment    10 % от крайната цена    15 % от крайната цена    20 % от крайната цена

            if (room == "apartment")
            {
                if (days < 10)
                {
                    apartment =apartment-apartment* 0.30;
                }
                else if (days > 10 && days <= 15)
                {
                    apartment =apartment-apartment* 0.35;
                }
                else if (days > 15)
                {
                    apartment =apartment-apartment* 0.50;
                }
            }
            else if(room=="president apartment")
            {
                if (days < 10)
                {
                    presidentApartment = presidentApartment - presidentApartment * 0.10;
                }
                else if (days > 10 && days <= 15)
                {
                    presidentApartment = presidentApartment - presidentApartment * 0.15;
                }
                else if (days > 15)
                {
                    presidentApartment = presidentApartment - presidentApartment * 0.20;
                }
            }
           

            if (feedback == "positive")
            {
                switch (room)
                {
                    case "room for one person":
                        Console.WriteLine($"{(roomForOne = roomForOne + roomForOne * 0.25):f2}");
                        break;
                    case "apartment":
                        Console.WriteLine($"{(apartment=apartment+apartment*0.25):f2}");
                        break;
                    case "president apartment":
                        Console.WriteLine($"{(presidentApartment=presidentApartment+presidentApartment*0.25):f2}");
                        break;
                }
            }
            else if(feedback=="negative")
            {
                switch (room)
                {
                    case "room for one person":
                        Console.WriteLine($"{(roomForOne = roomForOne - roomForOne * 0.1):f2}");
                        break;
                    case "apartment":
                        Console.WriteLine($"{(apartment = apartment - apartment * 0.1):f2}");
                        break;
                    case "president apartment":
                        Console.WriteLine($"{(presidentApartment = presidentApartment - presidentApartment * 0.1):f2}");
                        break;
                }
            }
        }
    }
}
