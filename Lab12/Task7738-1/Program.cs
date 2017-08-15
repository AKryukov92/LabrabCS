using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7738_1
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
            Dictionary <string, int> dict= new Dictionary<string, int>();
            string line;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                if (dict.ContainsKey(line))
                {
                    int x = dict[line];
                    dict[line] = x + 1;
                } else
                {
                    dict.Add(line, 1);
                }
            }
            reader.Close();
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
