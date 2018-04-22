using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static double GetValue(double x)
        {
            if (x < -1)
                return -1 / Math.Pow(x, 2);
            if (x < 2)
                return Math.Pow(x, 2);
            return 4;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 3\n=================");
            Console.WriteLine("Условие задачи:\nДано действительное число a. Для функций f(x), " +
                              "графики которых предствлены на рисунке, вычислить f(a).\n" +
                              "=================");
            double input;
            bool ok;
            Console.Write("Введите действительное число \"a\" для того, чтобы узнать значение функции f(a) на графике: ");
            do
            {
                ok = double.TryParse(Console.ReadLine(), out input);
                if (!ok)
                    Console.WriteLine("Ошибка! Введите вещественное число.");
            } while (!ok);

            double result = GetValue(input);
            Console.WriteLine("Ответ: Значение функции f(a) в точке a = {0} равно {1}", input, result);
        }
    }
}
