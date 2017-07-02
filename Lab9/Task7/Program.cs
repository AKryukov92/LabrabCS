using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер файла: ");
            string input = Console.ReadLine();
            string filename = "test" + input + ".txt";
            Console.WriteLine("Введите букву: ");
            string A = Console.ReadLine();
            Console.WriteLine("Введите букву: ");
            string B = Console.ReadLine();
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
            int C = 0;
            int index1;
            int index2;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (!line.Contains(A) || !line.Contains(B))
                {
                    Console.WriteLine("Одна из указанных букв не найдена");
                    return;
                }
                index1 = line.IndexOf(A);
                index2 = line.IndexOf(B);
                if (line.IndexOf(A) != line.LastIndexOf(A) || line.IndexOf(B) != line.LastIndexOf(B))
                {
                    Console.WriteLine("В данной строке несколько искомых букв");
                    return;
                }
                if (index2 > index1)
                {
                    C = index2 - index1 - 1;
                }
                else
                {
                    C = index1 - index2 - 1;
                }
            }
            reader.Close();
            Console.WriteLine(C);
        }
    }
}
