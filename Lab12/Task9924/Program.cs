using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.task9924;

namespace Task9924
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер файла: ");
            string input = Console.ReadLine();
            string filename = "test" + input + ".csv";
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
            string line;
            string[] sarr;
            ISet<Point> set = new HashSet<Point>();
            try {
                do
                {
                    line = reader.ReadLine();
                    sarr = line.Split(';');
                    if (sarr.Length != 3)
                    {
                        Console.WriteLine("Некорректный формат");
                        return;
                    }
                    else
                    {
                        Point p = new Point(int.Parse(sarr[0]), int.Parse(sarr[1]));
                        p.color = sarr[2];
                        set.Add(p);
                    }
                }
                while (!reader.EndOfStream);
                reader.Close();
                Console.WriteLine(String.Join("\n", set));
                }
            catch (Exception e)
            {
                Console.WriteLine("Не удается считать число");
            }
        }
    }
}
