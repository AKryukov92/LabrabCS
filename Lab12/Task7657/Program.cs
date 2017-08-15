using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.task7657;
using System.IO;

namespace Task7657
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
            int i = 0;
            ISet<Point> set = new HashSet<Point>();
            Dictionary <Point, int> dict= new Dictionary<Point, int>();
                do
                {
                    line = reader.ReadLine();
                    sarr = line.Split(';');
                    if (sarr.Length != 3||sarr[2]=="")
                    {
                        i++;
                    }
                    else
                    {
                        try
                        {
                            Point p = new Point(int.Parse(sarr[0]), int.Parse(sarr[1]));
                            p.color = sarr[2];
                            set.Add(p);
                            if (dict.ContainsKey(p))
                            {
                                int x = dict[p];
                                dict.Remove(p);
                                dict.Add(p, x + 1);
                            }
                            else
                            {
                                dict.Add(p, 1);
                            }
                        }
                        catch (Exception e)
                        {
                            i++;
                        }
                    }
                }
                while (!reader.EndOfStream);
                reader.Close();
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine("Некорректных записей: " + i);
        }
   }
    
}
