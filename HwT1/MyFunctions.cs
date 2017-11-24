using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwT1
{
    public delegate double Func(double x, double a);

    class MyFunctions
    {
        private static string fname = "Default";
        public static string FName { get => fname; }

        public static double F1(double x, double a) { fname = "Функция: a * x"; return a * x; }

        public static double F2(double x, double a) { fname = "Функция: a * x + x"; return a * x + x; }

        public static double F3(double x, double a) { fname = "Функция: 1 / (a * x)"; return 1 / (a * x); }

        public static double F4(double x, double a) { fname = "Функция: a * Math.Pow(x, 2)"; return a * Math.Pow(x, 2); }

        public static double F5(double x, double a) { fname = "Функция: a * Math.Sin(x)"; return a * Math.Sin(x); }
    }
}
