﻿using System;

namespace ConditionalStatementsAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            //„+“, „-“, „*“, „/“, „%“
            char operation = char.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    int sum = number1 + number2;
                    //ако е четен "{N1} {оператор} {N2} = {резултат} – even"
                    //ако е нечетен "{N1} {оператор} {N2} = {резултат} – odd"
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{number1} + {number2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} + {number2} = {sum} - odd");
                    }
                    break;
                case '-':
                    int diff = number1 - number2;
                    if (diff % 2 == 0)
                    {
                        Console.WriteLine($"{number1} - {number2} = {diff} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} - {number2} = {diff} - odd");
                    }
                    break;
                case '*':
                    int result = number1 * number2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{number1} * {number2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} * {number2} = {result} - odd");
                    }
                    break;
                case '/':
                    //проверка дали n2 == 0
                    if (number2 == 0)
                    {
                        //не можем да делим
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                    {
                        double division = number1 * 1.0 / number2;
                        Console.WriteLine($"{number1} / {number2} = {division:F2}");
                    }
                    break;
                case '%':
                    if (number2 == 0)
                    {
                        //не можем да делим
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                    {
                        int leftOver = number1 % number2;
                        Console.WriteLine($"{number1} % {number2} = {leftOver}");
                    }
                    break;
            }

        }
    }
}