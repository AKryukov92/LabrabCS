using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
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
            Console.WriteLine("Введите букву: ");
            string A = Console.ReadLine();
            int L = 0;
            int i;
            int j = 0;
            int v = 0;
            string fragment;
            string t="";
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                L = line.Length;
                i = 0;
                while (i < L)
                {
                    t = line.Substring(i, 1);
                    if (t.Contains(A))
                    {
                        v = v + 1;
                    }
                    if (t.Contains("\""))
                    {
                        v = 0;
                    }
                    i++;
                }
                Console.Write(v + " ");
                j++;
            }
            reader.Close();
        }
    }
}
