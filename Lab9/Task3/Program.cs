using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите букву: ");
            string t = Console.ReadLine();
            Console.WriteLine("Введите номер файла: ");
            string input = Console.ReadLine();
            string filename = "test" + input + ".txt";
            if (!File.Exists(filename))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            StreamReader reader = new StreamReader(filename);
            int C = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line.Contains(t))
                {
                C++;
                }
            }
            reader.Close();
            Console.WriteLine(C);
        }
    }
}
