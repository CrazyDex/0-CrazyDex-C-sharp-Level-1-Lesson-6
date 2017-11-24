using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwT2
{
    //Denis Evdokhin

    //*Модифицировать программу нахождения минимума функции так, чтобы можно было
    //передавать функцию в виде делегата.Сделать меню с различными функциями и представьте
    //пользователю выбор для какой функции и на каком отрезке находить минимум.Используйте
    //массив делегатов.

    class Program
    {
        static void Printer(MinFunc func, double beg, double end, double shag = 1) { Console.WriteLine("\nМинимум на заданном отрезке: " + func(beg, end, shag)); }
        static void Printer(MinFuncA func, double beg, double end, double a, double shag = 1) { Console.WriteLine("\nМинимум на заданном отрезке: " + func(beg, end, a, shag)); }
        static void Printer(MinFuncAB func, double beg, double end, double a, double b, double shag = 1) { Console.WriteLine("\nМинимум на заданном отрезке: " + func(beg, end, a, b, shag)); }
        static void Printer(MinFuncABC func, double beg, double end, double a, double b, double c, double shag = 1) { Console.WriteLine("\nМинимум на заданном отрезке: " + func(beg, end, a, b, c, shag)); }

        static void Main(string[] args)
        {
            Console.WriteLine("Укажите минимум какой функции вы хотите найти:\n" +
                "1. y = x\n" +
                "2. y = (1 / x)\n" +
                "3. y = (a * x)\n" +
                "4. y = (a / x)\n" +
                "5. y = (a * x + b)\n" +
                "6. y = ((a * x) / b)\n" +
                "7. y = (a * x^2 + b * x + c)\n" +
                "8. y = ((a * x^2 + b) / (x * c))\n");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Укажите начало отрезка, конец отрезка, шаг");
                    Printer(Funcs.F1, Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                    break;
                case 2:
                    Console.WriteLine("Укажите начало отрезка, конец отрезка, шаг");
                    Printer(Funcs.F2, Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                    break;
                case 3:
                    Console.WriteLine("Укажите начало отрезка, конец отрезка, аргумент a, шаг");
                    Printer(Funcs.FA1, Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                    break;
                case 4:
                    Console.WriteLine("Укажите начало отрезка, конец отрезка, аргумент a, шаг");
                    Printer(Funcs.FA2, Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                    break;
                case 5:
                    Console.WriteLine("Укажите начало отрезка, конец отрезка, аргумент a, аргумент b, шаг");
                    Printer(Funcs.FAB1, Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                    break;
                case 6:
                    Console.WriteLine("Укажите начало отрезка, конец отрезка, аргумент a, аргумент b, шаг");
                    Printer(Funcs.FAB2, Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                    break;
                case 7:
                    Console.WriteLine("Укажите начало отрезка, конец отрезка, аргумент a, аргумент b, аргумент c, шаг");
                    Printer(Funcs.FABC1, Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                    break;
                case 8:
                    Console.WriteLine("Укажите начало отрезка, конец отрезка, аргумент a, аргумент b, аргумент c, шаг");
                    Printer(Funcs.FABC2, Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                    break;
                default:
                    break;
            }


            

            Console.ReadKey();
        }

    }
}
