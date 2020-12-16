using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string mernaEdinica=Console.ReadLine();
            string iskanataMernaEdinica=Console.ReadLine();

            double inMeterse = 0;
            double result = 0;

            if (mernaEdinica=="mm")
            {
                inMeterse = number/1000;
                
            }
            else if (mernaEdinica =="cm")
            {
                inMeterse = number/100;
                
            }
            else if (mernaEdinica== "m")
            {
               inMeterse = number;
                
            }

            if (iskanataMernaEdinica == "mm")
            {
                result = inMeterse * 1000;
            }
            else if (iskanataMernaEdinica == "cm")
            {
                result = inMeterse*100;
            }
            else if (iskanataMernaEdinica == "m")
            {
                result = inMeterse;
            }
            Console.WriteLine($"{result:f3}");
        }
    }
}
//using system;

//namespace metric_converter
//{
//    class program
//    {
//        static void main(string[] args)
//        {
//            double number = double.parse(console.readline());
//            string from = console.readline();
//            string to = console.readline();
//            double inmeters = 0;
//            double result = 0;

//            if (from == "mm") inmeters = number / 1000;
//            else if (from == "cm") inmeters = number / 100;
//            else if (from == "m") inmeters = number;

//            if (to == "mm") result = inmeters * 1000;
//            else if (to == "cm") result = inmeters * 100;
//            else if (to == "m") result = inmeters;

//            console.writeline($"{result:f3}");
//        }
//    }
//}