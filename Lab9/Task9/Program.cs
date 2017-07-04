using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
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
            int index;
            string name;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                index = line.IndexOf("@");
                if (!line.Contains("@") || !line.Contains(".") || line.IndexOf("@")!=line.LastIndexOf("@") || 
                    line.Substring(0,1)=="@")
                {
                    Console.WriteLine("Некорректное имя файла");
                }
                else
                {
                    name = line.Substring(0, index);
                    Console.WriteLine(name);
                }
            }
            reader.Close();
        }
    }
}
