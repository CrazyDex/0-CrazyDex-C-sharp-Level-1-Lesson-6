using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwT2
{
    public delegate double MinFunc(double beg, double end, double shag);
    public delegate double MinFuncA(double beg, double end, double a, double shag = 1);
    public delegate double MinFuncAB(double beg, double end, double a, double b, double shag = 1);
    public delegate double MinFuncABC(double beg, double end, double a, double b, double c, double shag = 1);

    class Funcs
    {
        private static double res;
        private static double min;

        // y = x
        public static double F1(double x, double end, double shag)
        {
            min = x;
            while (x <= end)
            {
                res = x;
                min = min < res ? min : res;
                x += shag;
            }
            if (x % end != 0)
            {
                x = end;
                res = x;
                min = min < res ? min : res;
            }
            return min;
        }

        // y = (1 / x)
        public static double F2(double x, double end, double shag)
        {
            min = (1 / x);//form
            while (x <= end)
            {
                res = (1 / x);//form
                min = min < res ? min : res;
                x += shag;
            }
            if (x % end != 0)
            {
                x = end;
                res = (1 / x);//form
                min = min < res ? min : res;
            }
            return min;
        }

        // y = (a * x)
        public static double FA1(double x, double end, double a, double shag)
        {
            min = (a * x);//form
            while (x <= end)
            {
                res = (a * x);//form
                min = min < res ? min : res;
                x += shag;
            }
            if (x % end != 0)
            {
                x = end;
                res = (a * x);//form
                min = min < res ? min : res;
            }
            return min;
        }

        // y = (a / x)
        public static double FA2(double x, double end, double a, double shag)
        {
            min = (a / x);//form
            while (x <= end)
            {
                res = (a / x);//form
                min = min < res ? min : res;
                x += shag;
            }
            if (x % end != 0)
            {
                x = end;
                res = (a / x);//form
                min = min < res ? min : res;
            }
            return min;
        }

        // y = (a * x + b)
        public static double FAB1(double x, double end, double a, double b, double shag)
        {
            min = (a * x + b);//form
            while (x <= end)
            {
                res = (a * x + b);//form
                min = min < res ? min : res;
                x += shag;
            }
            if (x % end != 0)
            {
                x = end;
                res = (a * x + b);//form
                min = min < res ? min : res;
            }
            return min;
        }

        // y = ((a * x) / b)
        public static double FAB2(double x, double end, double a, double b, double shag)
        {
            min = ((a * x) / b);//form
            while (x <= end)
            {
                res = ((a * x) / b);//form
                min = min < res ? min : res;
                x += shag;
            }
            if (x % end != 0)
            {
                x = end;
                res = ((a * x) / b);//form
                min = min < res ? min : res;
            }
            return min;
        }

        // y = (a * x^2 + b * x + c)
        public static double FABC1(double x, double end, double a, double b, double c, double shag)
        {
            min = (a * Math.Pow(x, 2) + b * x + c);//form
            while (x <= end)
            {
                res = (a * Math.Pow(x, 2) + b * x + c);//form
                min = min < res ? min : res;
                x += shag;
            }
            if (x % end != 0)
            {
                x = end;
                res = (a * Math.Pow(x, 2) + b * x + c);//form
                min = min < res ? min : res;
            }
            return min;
        }

        // y = ((a * x^2 + b) / (x * c))
        public static double FABC2(double x, double end, double a, double b, double c, double shag)
        {
            min = ((a * Math.Pow(x, 2) + b) / (x * c));//form
            while (x <= end)
            {
                res = ((a * Math.Pow(x, 2) + b) / (x * c));//form
                min = min < res ? min : res;
                x += shag;
            }
            if (x % end != 0)
            {
                x = end;
                res = ((a * Math.Pow(x, 2) + b) / (x * c));//form
                min = min < res ? min : res;
            }
            return min;
        }
    }
}
