using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер файла: ");
            string input = Console.ReadLine();
            string filename = "test" + input + ".txt";
            if (!File.Exists(filename))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            StreamReader reader = new StreamReader(filename);
            if (reader.EndOfStream)
            {
                Console.WriteLine("Файл пуст");
                return;
            }
            int L = 0;
            int i;
            int j = 0;
            int v = 0;
            int M = 0;
            string t;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                L = line.Length;
                i = 0;
                while (i < L)
                {
                    t = line.Substring(i, 1);
                    if (t.Contains("{"))
                    {
                        v = v + 1;
                        //Console.Write(v);
                    }
                    else
                    {
                        v = v - 1;
                        //Console.Write(v);
                    }
                    if (v > M)
                    {
                        M = v;
                    }
                    i++;
                }
                j++;
            }
            if (v >= 1 && j > 1 || v >= 1 && L > 1)
            {
                Console.WriteLine("Неожиданный конец файла");
            }
            if (v < 0)
            {
                Console.WriteLine("Неожиданная закрывающаяся скобочка");
            }
            if (v == 0)
            {
                Console.WriteLine(M);
            }
            reader.Close();
        }
    }
}
