using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
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
            int index1;
            int index2;
            string name;
            string s;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                index1=line.LastIndexOf("\\");
                int L=line.Length;
                s = line.Substring(index1 + 1, L-index1-1);
                if (s.Contains("."))
                {
                    index2 = s.LastIndexOf(".");
                    name = s.Substring(0, index2);
                }
                else
                {
                    name = s;
                }
                if (name.Contains("*") || name.Contains("|") || name.Contains("\\") || name.Contains(":") || name.Contains("\"")
                    || name.Contains("<") || name.Contains(">") || name.Contains("?") || name.Contains("/"))
                {
                    Console.WriteLine("Некорректное имя файла");
                }
                else
                {
                    Console.WriteLine(name);
                }
                
            }
            reader.Close();
        }
    }
}
