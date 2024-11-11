using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8
namespace PracticeTask01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void PrintMaxDigit()// Бес аргумента
            {
                int number_random = new Random().Next(10, 100);
                Console.WriteLine(number_random);

                int numberA = number_random / 10;
                int numberB = number_random % 10;
                if (numberA > numberB)
                {
                    Console.WriteLine(numberA);
                }
                else
                {
                    Console.WriteLine(numberB);
                }
            }
            //PrintMaxDigit();

            void PrintMaxDigitArg(int number_ran) //С аргументом
            {
                
                int numberA = number_ran / 10;
                int numberB = number_ran % 10;
                if (numberA > numberB)
                {
                    Console.WriteLine(numberA);
                }
                else
                {
                    Console.WriteLine(numberB);
                }
            }
            //PrintMaxDigitArg(int.Parse(Console.ReadLine()));

            string PrintMaxDigitReturn(int random)
            {
                int numberA = random / 100;
                int numberB = random % 10;
                return $"{numberA}{numberB}";
            }
            int num_random = new Random().Next(10, 1000);
            Console.WriteLine($"Сгенерированное число: {num_random}"); ;
            Console.WriteLine(PrintMaxDigitReturn(num_random));


        }
    }
}
