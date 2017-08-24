using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.task6981_1;

namespace Task6981
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
            int i = 0;
            string[] sarr;
            Rectangle R;
            Circle C;
            Dictionary<string, Shape> dict = new Dictionary<string, Shape>();
            Dictionary<string, int> count = new Dictionary<string, int>();//сколько действий 
                do
                {
                    try
                    {
                        string line = reader.ReadLine();
                        sarr = line.Split(';');
                        if (sarr[0] == "create" && sarr[1] == "rectangle" && !dict.ContainsKey(sarr[1]))
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
                            string type = sarr[1];
                            string Id = sarr[2];
                            int cx = int.Parse(sarr[3]);
                            int cy = int.Parse(sarr[4]);
                            int r = int.Parse(sarr[5]);
                            C = new Circle(Id, cx, cy, r);
                            dict.Add(Id, C);
                            count.Add(Id, 0);
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
                    catch (Exception e)
                    {
                        i++;
                    }
                }
                while (!reader.EndOfStream);
            foreach (var item in dict)
            {
                int x = count[item.Key];
                Console.WriteLine(item.Key + " " + "действий: " + x + " " + item.Value);
            }
            Console.WriteLine("Некорректных записей: " + i);
            reader.Close();
        }
    }
}
