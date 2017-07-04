using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1
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
            int i = 1;//номер строки
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (i == 1)
                {
                    Console.Write(line);
                }
                else
                {
                    Console.Write(", " + line);
                }
                i++;
            }
            reader.Close();
        }
    }
}
