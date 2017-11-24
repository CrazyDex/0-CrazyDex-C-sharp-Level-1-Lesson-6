using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace BigSeries
{
    // SMOTRI HwT3Reliz
    // SMOTRI HwT3Reliz
    // SMOTRI HwT3Reliz
    // SMOTRI HwT3Reliz
    // SMOTRI HwT3Reliz

    class Program
    {
        struct Dig
        {
            public int index;
            public int num;
            public Dig(int a, int b)
            {
                index = a;
                num = b;
            }

            public override string ToString()
            {
                return $"{index} : {num}";
            }

        }

        static void Main(string[] args)
        {
            Random random = new Random();
            List<Dig> digs = new List<Dig>();
            for (int i = 0; i < 10; i++)
            {
                digs.Add(new Dig(i, random.Next(0, 10)));
                Console.WriteLine(digs[i]);
            }
            var sdigs = digs.OrderByDescending(e => e.num);
            do
            {
                int i = 0;
                foreach (var item in sdigs)
                {
                    digs[i++] = item;
                }
            } while (false);
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(digs[i]);
            }
            int max = 0;
            int res;
            for (int i = 0; i < 8; i++)
            {
                for (int k = 1; k <= 8 ; k++)
                {
                    if (Math.Abs(digs[i].index - digs[k].index) >= 8)
                    {
                        res = digs[i].num * digs[k].num;
                        max = max < res ? res : max;
                    }
                }
                
            }
            Console.WriteLine();
            Console.WriteLine(max);

            Console.ReadKey();
        }
    }
}