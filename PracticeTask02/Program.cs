using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98
namespace PracticeTask02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void RandomDigitNumber()
            {
                int three_number = new Random().Next(100, 1000);
                Console.WriteLine(three_number);

                int three_number1 = three_number / 100;
                int three_number2 = three_number % 10;
                Console.WriteLine($"{three_number1}{three_number2}");
            }
            RandomDigitNumber();
        }
    }
}
