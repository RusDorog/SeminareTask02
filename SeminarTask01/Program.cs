using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

//необязательная задача.


namespace SeminarTask01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ThreeNumberDigital()
            {
                // Генерация случайного трехзначного числа
                int random = new Random().Next(100, 1000);
                // Извлечение второй цифры (десятков)
                int num_three = (random / 10) % 10;
                // Формирование строки с результатом
                return $"Случайное число: {random}, Вторая цифра числа: {num_three}";
            }
            Console.WriteLine(ThreeNumberDigital());
        }
    }
}
