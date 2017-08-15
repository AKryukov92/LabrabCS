using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9990
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
            ISet<String> set = new HashSet<String>();
            string line;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                set.Add(line);
            }
            reader.Close();
            Console.WriteLine(String.Join(", ", set));
        }
    }
}
