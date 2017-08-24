using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.task5108;
using System.IO;

namespace Task5108
{
    class Program
    {
        static void Main(string[] args)
        {
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
            string[] sarr;
            int z;
            Rectangle r;
            Dictionary <string, Rectangle> dict = new Dictionary<string, Rectangle>();
            Dictionary <string, int> count = new Dictionary<string, int>();//сколько действий 
            do
                {
                    string line = reader.ReadLine();
                    sarr = line.Split(';');
                    if (sarr.Length != 3 && sarr.Length != 6)
                    {
                        Console.WriteLine("Некорректный формат");
                        return;
                    }
                    z = int.Parse(sarr[2]);
                    if (sarr[0] == "create" && !dict.ContainsKey(sarr[1]))
                    {
                        string Id = sarr[1];
                        int Xn = int.Parse(sarr[2]);
                        int Yn = int.Parse(sarr[3]);
                        int W = int.Parse(sarr[4]);
                        int H = int.Parse(sarr[5]);
                        r = new Rectangle(Id, Xn, Yn, W, H);
                        dict.Add(Id, r);
                        count.Add(Id, 0);
                    }
                    else if (sarr[0] == "create" && dict.ContainsKey(sarr[1]))
                    {
                        Console.WriteLine("Идентификатор не должен повторяться");
                        return;
                    }
                    else if (!dict.ContainsKey(sarr[1]) && !count.ContainsKey(sarr[1]))
                    {
                        Console.WriteLine("Операция над неопознанным объектом");
                        return;
                    }
                    else if (sarr[0] == "shiftX" && dict.ContainsKey(sarr[1]) && count.ContainsKey(sarr[1]))
                    {
                        dict[sarr[1]].shiftX(z);
                        if (dict[sarr[1]].Xn < 0)
                        {
                            Console.WriteLine("Координата X должна быть неотрицательной");
                            return;
                        }
                        count[sarr[1]]++;
                    }
                    else if (sarr[0] == "shiftY" && dict.ContainsKey(sarr[1]) && count.ContainsKey(sarr[1]))
                    {
                        dict[sarr[1]].shiftY(z);
                        if (dict[sarr[1]].Yn < 0)
                        {
                            Console.WriteLine("Координата Y должна быть неотрицательной");
                            return;
                        }
                        count[sarr[1]]++;
                    }
                    else if (sarr[0] == "stretchX" && dict.ContainsKey(sarr[1]) && count.ContainsKey(sarr[1]))
                    {
                        dict[sarr[1]].stretchX(z);
                        if (dict[sarr[1]].W <= 0)
                        {
                            Console.WriteLine("Ширина должна быть положительной");
                            return;
                        }
                        count[sarr[1]]++;
                    }
                    else if (sarr[0] == "stretchY" && dict.ContainsKey(sarr[1]) && count.ContainsKey(sarr[1]))
                    {
                        dict[sarr[1]].stretchY(z);
                        if (dict[sarr[1]].H <= 0)
                        {
                            Console.WriteLine("Высота должна быть положительной");
                            return;
                        }
                        count[sarr[1]]++;
                    }
                    else
                    {
                        Console.WriteLine("Некорректное действие: " + sarr[0]);
                        return;
                    }
                }
                while (!reader.EndOfStream);
            //var list = dict.Keys.ToList();// упорядочить
            //list.Sort();
            //foreach (var key in list)
            //{
            //    var item = dict[key];
            //    int x = count[key];
            //    Console.WriteLine(key + " " + "действий: " + x + " " + dict[key]);
            //}
            foreach (var item in dict)
            {
                int x = count[item.Key];
                Console.WriteLine(item.Key + " " + "действий: " + x + " " + item.Value);
            }
        }
    }
}
