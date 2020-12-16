using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiNezadovolitelniOcenki = int.Parse(Console.ReadLine());

           
            int countNezadovolitelniOcenki = 0; //брояч лоши оценки
            int countZadachi = 0; //брояч за решенията
            double sumOcenki= 0;//сумата на всички оценки
            int countOcenki = 0;
            string poslednaZadacha ="";// последна задача
            
           

            
            while (countNezadovolitelniOcenki < broiNezadovolitelniOcenki)
            {

               string imeZadacha = Console.ReadLine();
                

                if (imeZadacha=="Enough")
                {
                    Console.WriteLine($"Average score: {(sumOcenki/countOcenki):f2}");
                    Console.WriteLine($"Number of problems: {countZadachi}");
                    Console.WriteLine($"Last problem: {poslednaZadacha}"); 

                    break;
                }
                int ocenka = int.Parse(Console.ReadLine());

                if (ocenka <= 4)
                {

                    countNezadovolitelniOcenki++;
                }
                sumOcenki += ocenka;
                countOcenki++;
                countZadachi++;
                poslednaZadacha=imeZadacha;
                
            }
            if (countNezadovolitelniOcenki >= broiNezadovolitelniOcenki)
            {
                Console.WriteLine($"You need a break, {broiNezadovolitelniOcenki} poor grades.");
            }
           
            
           
        }
    }
}
