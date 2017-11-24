using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwT1
{
    //Evdokhin Denis

    //Изменить программу вывода функции так, чтобы можно было передавать функции типа double(double,double).
    //Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).


    

    class Program
    {
        static void Main(string[] args)
        {
            PrintFunc.Print(MyFunctions.F1, 3, 5, 10);
            Console.WriteLine();
            PrintFunc.Print(MyFunctions.F2, 3, 5, 10);
            Console.WriteLine();
            PrintFunc.Print(MyFunctions.F3, 3, 5, 10);
            Console.WriteLine();
            PrintFunc.Print(MyFunctions.F4, 3, 5, 10);
            Console.WriteLine();
            PrintFunc.Print(MyFunctions.F5, 3, 5, 10);

            Console.ReadLine();
        }
    }
}
