using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
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
            int i = 0;
            int C=0;
            string line = reader.ReadLine();
            int L = line.Length;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                L = line.Length;
                if (L > 4)
                {
                    Console.WriteLine("Запись длиннее четырех символов");
                    return;
                }
                if (L < 4)
                {
                    Console.WriteLine("Запись короче четырех символов");
                    return;
                }
                i = 0;
                while (i < L-1)
                {
                    if (line.Substring(i, 1) == line.Substring(i + 1, 1))
                    {
                        C++;
                        break;
                    }
                    i++;
                }
            }
            reader.Close();
            Console.Write(C);
        }
    }
}
