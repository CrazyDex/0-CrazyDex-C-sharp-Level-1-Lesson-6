using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwT1
{
    
    static class PrintFunc
    {
        public static void Print(Func func, double x, double a, double stop)
        {
            Console.WriteLine("x : y");
            while (x <= stop)
            {
                Console.WriteLine($"{x:0.00} : {func(x, a):0.00}");
                x++;
            }
            Console.WriteLine(MyFunctions.FName);
        }
    }
}
