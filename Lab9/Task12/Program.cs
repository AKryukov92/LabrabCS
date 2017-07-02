using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
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
            int count = 0;
            string t;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line.Contains("src"))
                {
                    index1 = line.IndexOf("\"");
                    index2 = line.LastIndexOf("\"");
                    t = line.Substring(index1+1, index2-index1-1);
                    Console.WriteLine(t);
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Сообщение об ошибке");
            }
            reader.Close();
        }
    }
}
