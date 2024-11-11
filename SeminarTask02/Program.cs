using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
namespace SeminarTask02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ThirdDigitOfTheNumber()
            {
                Random rnd = new Random();
                // Генерация случайного числа в диапазоне от -99999 до 99999
                int number = rnd.Next(-99999, 100000);
                Console.WriteLine($"Сгенерировалось случайное число {number}");
                // Преобразуем число в строку для удобства доступа к цифрам
                String number_string = Math.Abs(number).ToString();

                if (number_string.Length >= 3 )
                {
                    return($"Третья цифра числа {number_string[2]}");
                }
                else
                {
                    return("Третья цифра НЕТ");
                }
            }
            Console.WriteLine(ThirdDigitOfTheNumber());
        }
    }
}
