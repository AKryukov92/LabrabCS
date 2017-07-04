using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер файла: ");
            string input = Console.ReadLine();
            string filename = "test" + input + ".css";
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
            int index;
            string t;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line.Contains("{"))
                {
                    index = line.IndexOf("{");
                    t = line.Substring(0, index);
                    Console.WriteLine(t);
                }
            }
            reader.Close();
        }
    }
}
