using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6882
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
            string line = reader.ReadLine();
            try
            {
                int M = int.Parse(line);
                int X;
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    X = int.Parse(line);
                    if (X < M)
                    {
                        M = X;
                    }
                }
                Console.Write(M);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Не удается считать число");
            }
            reader.Close();
        }
    }
}
