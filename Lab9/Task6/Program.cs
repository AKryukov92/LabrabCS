using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
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
            Console.WriteLine("Введите букву: ");
            string A = Console.ReadLine();
            int C = 0;
            int L;
            int index;
            int index2;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (!line.Contains(A))
                {
                    Console.WriteLine("Указанная буква не найдена");
                    return;
                }
                L = line.Length;
                index = line.IndexOf(A);
                index2 = line.LastIndexOf(A);
                if (index!=index2)
                {
                    Console.WriteLine("В данной строке несколько искомых букв");
                    return;
                }
                C = L - index - 1;     
            }
            reader.Close();
            Console.Write(C);
        }
    }
}
