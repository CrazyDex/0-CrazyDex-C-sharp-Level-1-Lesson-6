using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HwT3test
{
    // SMOTRI HwT3Reliz
    // SMOTRI HwT3Reliz
    // SMOTRI HwT3Reliz
    // SMOTRI HwT3Reliz
    // SMOTRI HwT3Reliz

    class Program
    {
        //
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
        //

        static void Save(string fileName, int n)
        {
            Random rnd = new Random();
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 1; i < n; i++)
            {
                bw.Write(rnd.Next(0, 100_000)); // int -занимает 4 байта
            }
            fs.Close();
            bw.Close();
        }
        static void Load(string fileName)
        {
            DateTime d = DateTime.Now;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            int[] a = new int[fs.Length / 4];
            for (int i = 0; i < fs.Length / 4; i++) // int занимает 4 байта
            {
                a[i] = br.ReadInt32();
            }
            br.Close();
            fs.Close();
            int max = 0;
            int maxi = 0;
            int maxj = 0;
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < a.Length; j++)
                    if (Math.Abs(i - j) >= 8 && a[i] * a[j] > max)
                    {
                        max = a[i] * a[j];
                        maxi = i;
                        maxj = j;
                    }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(i);
                Console.Write(" ");
                Console.WriteLine(a[i]);
            }
            Console.WriteLine($"{a[maxi]}({maxi}) * {a[maxj]}({maxj}) = {max}");
            //Console.WriteLine(max);
            Console.WriteLine(DateTime.Now - d);
        }
        static void Loadmy(string fileName)
        {
            DateTime d = DateTime.Now;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            //
            List<Dig> digs = new List<Dig>();
            //



            
            for (int i = 0; i < fs.Length / 4; i++)
            {
                digs.Add(new Dig(i, br.ReadInt32()));
            }
            br.Close();
            fs.Close();



            var sdigs = digs.OrderByDescending(e => e.num);
            do
            {
                int i = 0;
                foreach (var item in sdigs)
                {
                    digs[i++] = item;
                }
            } while (false);
            int max = 0;
            int res;
            int maxi = 0;
            int maxk = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int k = 1; k <= 8; k++)
                {
                    if (Math.Abs(digs[i].index - digs[k].index) >= 8)
                    {
                        res = digs[i].num * digs[k].num;
                        if (max < res)
                        {
                            max = res;
                            maxi = i;
                            maxk = k;
                        }
                        //max = max < res ? res : max;
                    }
                }

            }
            for (int i = 0; i < digs.Count; i++)
            {
                Console.Write(i);
                Console.Write(" ");
                Console.WriteLine(digs[i]);
            }
            Console.WriteLine($"{digs[maxi]} * {digs[maxk]} = {max}");
            //Console.WriteLine(max);
            Console.WriteLine(DateTime.Now - d);
        }




        static void Main(string[] args)
        {
            Save("data.bin", 20);
            Load("data.bin");
            Console.WriteLine();
            Loadmy("data.bin");
            Console.ReadKey();
        }
    }
}
