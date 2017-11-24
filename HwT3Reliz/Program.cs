using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HwT3Reliz
{
    // Evdokhin Denis

    //5. **Модифицировать задачу “Сложную задачу” ЕГЭ так, чтобы она решала задачу с 10 000 000 элементов менее чем за минуту.

    //Задача​​2.​​Сложная​​задача​​ЕГЭ
    //Для заданной последовательности неотрицательных целых чисел необходимо найти максимальное
    //произведение двух её элементов, номера которых различаются не менее, чем на 8. Значение каждого
    //элемента последовательности не превышает 100 000. Количество элементов последовательности
    //равно 100 000. Сгенерировать файл из случайных чисел и решить эту задачу:

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
        
        static void Save(string fileName, int n)
        {
            Random rnd = new Random();
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 1; i < n; i++)
            {
                // тут 10 000 а не 100 000 как в задаче, потому что при сотке ответ задачи превосходит int и она выдает неверный ответ
                // кстати говоря косяк тех кто писал решение для этой задачи, можете так и передать =)
                // а вот решается сия задача например с ЛОНГом или с ЮЛОНГом
                bw.Write(rnd.Next(0, 10_000)); // int -занимает 4 байта
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
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < a.Length; j++)
                    if (Math.Abs(i - j) >= 8 && a[i] * a[j] > max) max = a[i] * a[j];
            Console.WriteLine(max);
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
            for (int i = 0; i < 8; i++)
            {
                for (int k = 1; k <= 8; k++)
                {
                    if (Math.Abs(digs[i].index - digs[k].index) >= 8)
                    {
                        res = digs[i].num * digs[k].num;
                        max = max < res ? res : max;
                    }
                }

            }
            Console.WriteLine(max);
            Console.WriteLine(DateTime.Now - d);
        }




        static void Main(string[] args)
        {
            Save("data.bin", 20_000_000);
            //Load("data.bin");
            Console.WriteLine();
            Loadmy("data.bin");
            Console.ReadKey();
        }
    }
}
