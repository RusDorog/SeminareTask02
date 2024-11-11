using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно
namespace PracticeTask03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string RemainderFromDivision()
            {
                Console.WriteLine("Введите первое число:");
                string main_num1 = Console.ReadLine();
                Console.WriteLine("Введите второе число:");
                string main_num2 = Console.ReadLine();

                int num1 = Convert.ToInt32(main_num1);
                int num2 = Convert.ToInt32(main_num2);

                if (num2 == 0)
                {
                    return "Ошибка: деление на ноль невозможно.";
                }

                int remainder = num1 % num2;

                if (remainder == 0)
                {
                    return $"Число {num1} делится без остатка на {num2}";
                }
                else
                {
                    return $"Число {num1} / {num2}, остаток от деления: {remainder}";
                }
            }
            Console.WriteLine(RemainderFromDivision());
        }

    }

}
