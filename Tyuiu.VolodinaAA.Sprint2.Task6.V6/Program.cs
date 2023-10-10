using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VolodinaAA.Sprint2.Task6.V6.Lib;

namespace Tyuiu.VolodinaAA.Sprint2.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт#2 |Выполнила: Володина А.А.|ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#2                                                                *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Володина Александра Александровна | ПКТб-23-1                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value1,value2;
            Console.WriteLine("Введите номер масти от 1 до 4: ");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите достоинство карты от 6 до 14: ");
            value2 = Convert.ToInt32(Console.ReadLine());

           
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string cardname = ds.FindCardNameAndValue(value1, value2);
            if (((value1 < 1) || (value1 > 4)) && ((value2 < 6) || (value2 > 14)))
            {
                Console.WriteLine("Неверно введенное значение!");
            }
            else
            {
                Console.WriteLine($"Карта с достоинством и мастью - " + cardname);
            }
            Console.ReadKey();
        }
    }
}
