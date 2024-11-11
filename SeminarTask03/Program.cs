using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
namespace SeminarTask03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string DayOfWeek()
            {
                Console.WriteLine("Введите цифру, дня недели (1-7): "); // Уточнение диапазона
                int week;
                // Проверка корректности ввода
                while (!int.TryParse(Console.ReadLine(), out week) || week < 1 || week > 7)
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 7.");
                }
                // Проверка на выходной
                if (week == 6 || week == 7)
                {
                    return $"{week} это выходной";
                }
                else
                {
                    return $"{week} это рабочий день";
                }
            }
            Console.WriteLine(DayOfWeek());
        }
    }
}
