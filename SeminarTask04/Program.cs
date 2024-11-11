using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали для него программу,
//по которой робот, когда заходит в комнату, считает количество программистов в ней и произносит его вслух: "n программистов".
//Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.
//Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное),
//выводящее это число в консоль вместе с правильным образом изменённым словом "программист", для того,
//чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.
//В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, как минимум до 1000 человек.
namespace SeminarTask04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ProgrammingTeam()
            {
                Random rnd = new Random();
                int programmer = rnd.Next(1, 1000);
                Console.WriteLine($"Сгенерировалось число {programmer}");

                if (programmer % 10 == 1 && programmer % 100 != 11)
                {
                    return $"{programmer} программист";
                }
                else if ((programmer % 10 == 2 || programmer % 10 == 3 || programmer % 10 == 4) &&
                           (programmer % 100 != 12 && programmer % 100 != 13 && programmer % 100 != 14))
                {
                    return $"{programmer} программиста";
                }
                else
                {
                    return $"{programmer} программистов";
                }
            }
            Console.WriteLine(ProgrammingTeam());

        }
    }
}
