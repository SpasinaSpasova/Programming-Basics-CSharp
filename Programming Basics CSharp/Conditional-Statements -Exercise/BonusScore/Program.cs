﻿using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            double bonus = 0;

            if (score <= 100)
            {
                 bonus = 5;
            }
            else if (score > 1000)
            {
                 bonus = score * 0.1;
            }
            else
            {
                 bonus = score * 0.2;
            }

            if(score % 2 == 0)
            {
              bonus+= 1;
            }
            else if(score%10==5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(bonus+score);
        }
    }
}
