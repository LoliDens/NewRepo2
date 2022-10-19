using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_minPow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numberDigree = 0;
            int lowerLimitRandom = 0;
            int upperLimitRandom = 101;
            int number = random.Next(lowerLimitRandom, upperLimitRandom);
            int numberOnThePower = 1;
            int numberToExponentiate = 2;

            while (numberOnThePower < number) 
            {
                numberOnThePower *= numberToExponentiate;
                numberDigree++;
            }

            Console.WriteLine($"Для числа {number} < {numberOnThePower}, где {numberOnThePower}, это {numberToExponentiate} в {numberDigree} степени");
            Console.ReadKey();
        }   
    }
}
