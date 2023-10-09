using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VolodinaAA.Sprint2.Task2.V14.Lib;

namespace Tyuiu.VolodinaAA.Sprint2.Task2.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Title = "Спринт#2 |Выполнила: Володина А.А.|ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#2                                                                *");
            Console.WriteLine("* Тема: Оператор if                                                       *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Володина Александра Александровна | ПКТб-23-1                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры и   *");
            Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x, y;
            Console.WriteLine("Введите значение X");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y");
            y = Convert.ToInt32(Console.ReadLine());
            DataService ds = new DataService();
            bool res;
            res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (res)
            {
                Console.WriteLine($"Точка с координатами ({x},{y}) находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine($"Точка с координатами({x},{y}) находится вне заштрихованной области");
            }
            Console.ReadKey();
        }
    }
}
