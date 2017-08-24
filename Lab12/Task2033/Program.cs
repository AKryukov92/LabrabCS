using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.task2033;

namespace Task2033
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
            Rectangle R;
            Circle C;
            Dictionary<string, Shape> dict = new Dictionary<string, Shape>();
            Dictionary<string, int> count = new Dictionary<string, int>();//сколько действий 
            try
            {
                do
                {
                    string line = reader.ReadLine();
                    sarr = line.Split(';');
                    if (sarr.Length != 3 && sarr.Length != 6  && sarr.Length != 7)
                    {
                        Exception error = new Exception ("Некорректный формат");
                        throw error;
                    }
                    if (sarr.Length != 7 && sarr[1] == "rectangle")
                    {
                        Exception error = new Exception("Некорректный формат");
                        throw error;
                    }
                    if (sarr.Length != 6 && sarr[1] == "circle")
                    {
                        Exception error = new Exception("Некорректный формат");
                        throw error;
                    }
                    if (sarr[0] == "create" && sarr[1] != "circle" && sarr[1] != "rectangle")
                    {
                        Console.WriteLine("Неизвестная фигура");
                        return;
                    }
                    else if (sarr[0] == "create" && sarr[1] == "rectangle" && !dict.ContainsKey(sarr[1]))
                    {
                        string Id = sarr[2];
                        int Xn = int.Parse(sarr[3]);
                        int Yn = int.Parse(sarr[4]);
                        int W = int.Parse(sarr[5]);
                        int H = int.Parse(sarr[6]);
                        R = new Rectangle(Id, Xn, Yn, W, H);
                        dict.Add(Id, R);
                        count.Add(Id, 0);
                    }
                    else if (sarr[0] == "create" && sarr[1] == "circle" && !dict.ContainsKey(sarr[2]))
                    {
                        string Id = sarr[2];
                        int cx = int.Parse(sarr[3]);
                        int cy = int.Parse(sarr[4]);
                        int r = int.Parse(sarr[5]);
                        C = new Circle(Id, cx, cy, r);
                        dict.Add(Id, C);
                        count.Add(Id, 0);
                    }
                    else if (sarr[0] == "create" && dict.ContainsKey(sarr[2]))
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
                        dict[sarr[1]].shiftX(int.Parse(sarr[2]));
                        count[sarr[1]]++;
                    }
                    else if (sarr[0] == "shiftY" && dict.ContainsKey(sarr[1]) && count.ContainsKey(sarr[1]))
                    {
                        dict[sarr[1]].shiftY(int.Parse(sarr[2]));
                        count[sarr[1]]++;
                    }
                    else if (sarr[0] == "stretchX" && dict.ContainsKey(sarr[1]) && count.ContainsKey(sarr[1]))
                    {
                        dict[sarr[1]].stretchX(int.Parse(sarr[2]));
                        count[sarr[1]]++;
                    }
                    else if (sarr[0] == "stretchY" && dict.ContainsKey(sarr[1]) && count.ContainsKey(sarr[1]))
                    {
                        dict[sarr[1]].stretchY(int.Parse(sarr[2]));
                        count[sarr[1]]++;
                    }
                }
                while (!reader.EndOfStream);
                foreach (var item in dict)
                {
                    int x = count[item.Key];
                    Console.WriteLine(item.Key + " " + "действий: " + x + " " + item.Value);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            reader.Close();
           
        }
    }
}
