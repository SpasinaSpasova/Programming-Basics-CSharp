using System;

namespace Fruit_or__Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string food = Console.ReadLine();
            //Плодовете "fruit" имат следните възможни стойности:  banana, apple, kiwi, cherry, lemon и grapes
            //Зеленчуците "vegetable" имат следните възможни стойности:  tomato, cucumber, pepper и carrot
            //Всички останали са "unknown"


            if (food == "banana" || food == "apple" || food == "cherry" || food == "lemon" || food == "grapes"||food=="kiwi")
            {
                Console.WriteLine("fruit");
            }
            else if(food == "tomato" || food == "cucumber" || food == "pepper" || food == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
