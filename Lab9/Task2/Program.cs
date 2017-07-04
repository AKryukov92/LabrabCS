using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
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
            int C=0;//количество записей
            string line = reader.ReadLine();
            
            Console.Write(line + " ");
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                C = C + 1;
            }
            Console.Write(C);
            reader.Close();
        }
    }
}
