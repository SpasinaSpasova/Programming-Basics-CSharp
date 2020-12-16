using System;

namespace _09._OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());

            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinute = int.Parse(Console.ReadLine());

            int examMinutes = examHour * 60 + examMinute;
            int arriveMinutes = arriveHour * 60 + arriveMinute;

            //•	“Late”, ако студентът пристига по-късно от часа на изпита.
            //•	“On time”, ако студентът пристига точно в часа на изпита или до 30 минути по-рано.
            //•	“Early”, ако студентът пристига повече от 30 минути преди часа на изпита.

            if (arriveMinutes > examMinutes)
            {
                //Late
                int late = arriveMinutes - examMinutes; //закъснение
                Console.WriteLine("Late");

                //“mm minutes after the start” за закъснение под час.
                if (late < 60)
                {
                    Console.WriteLine($"{late} minutes after the start");
                }
                else
                {
                    int lateHour = late / 60;
                    int lateMinute = late % 60;
                    Console.WriteLine($"{lateHour}:{lateMinute:D2} hours after the start");
                }
                //“hh: mm hours after the start” за закъснение от 1 час или повече.
               //Минутите винаги печатайте с 2 цифри, например “1:03”.

               
            }
            else if (arriveMinutes == examMinutes || examMinutes-arriveMinutes <= 30)
            {
                //OnTime
                Console.WriteLine("On time");
                if (examMinutes - arriveMinutes <= 30 && examMinutes != arriveMinutes)
                {
                    Console.WriteLine($"{examMinutes - arriveMinutes} minutes before the start");
                }
            }
            else if (examMinutes-arriveMinutes > 30)
            {
                //Early
                int early = examMinutes - arriveMinutes;
                Console.WriteLine("Early");
                if (early < 60)
                {
                    Console.WriteLine($"{early}minutes before the start");
                }
                else
                {
                    int earlyHour = early / 60;
                    int earlyMinute = early % 60;
                    Console.WriteLine($"{earlyHour}:{earlyMinute:D2} hours before the start");
                }


                //•	“mm minutes before the start” за идване по-рано с по-малко от час.
               //“hh: mm hours before the start” за подраняване с 1 час или повече.
               //Минутите винаги печатайте с 2 цифри, например “1:05”.

            }

        }
    }
}
