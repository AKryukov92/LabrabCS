using Classes.task3567;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3567
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
            Circle c = new Circle(150, 150, 100);
            string[] sarr;
            int i = 0;
            int z;
            try
            {
                do
                {
                    string line = reader.ReadLine();
                    sarr = line.Split(';');
                    if (sarr.Length != 2)
                    {
                        Console.Write("действий:" + i + " ");
                        Console.WriteLine("Некорректный формат");
                        return;
                    }
                    z = int.Parse(sarr[1]);
                    if (sarr[0] == "shiftX")
                    {
                        c.shiftX(z);
                    }
                    else
                    if (sarr[0] == "shiftY")
                    {
                        c.shiftY(z);
                    } 
                    else if (sarr[0] == "stretchX")
                    {
                        c.stretchX(z);
                    }
                    else if (sarr[0] == "stretchY")
                    {
                        c.stretchY(z);
                    }
                    else
                    {
                        Console.WriteLine("Некорректное действие: " + sarr[0]);
                        return;
                    }
                    i++;
                }
                while (!reader.EndOfStream);
                Console.WriteLine("действий:" + i + c);
            }
            catch (Exception e)
            {
                Console.Write("действий:" + i + " ");
                Console.WriteLine(e.Message);
            }
            reader.Close();
        }
    }
}

