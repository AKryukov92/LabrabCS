using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер файла: ");
            string input = Console.ReadLine();
            string filename = "test" + input + ".html";
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
            int index1;
            int index2;
            int index3;
            int index4;
            int index5;
            int index6;
            string t1="";
            string t2="";
            int C = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line.Contains("name"))
                {
                    index1 = line.IndexOf("name");
                    index2 = line.IndexOf("\"", index1);
                    index3 = line.IndexOf("\"", index2 + 1);
                    t1 = line.Substring(index2 + 1, index3 - index2 - 1);
                    if (t1.Contains(" "))
                    {
                        t1 = t1.Replace(" ", "+");
                    }
                    if (line.Contains("value"))
                    {
                        index4 = line.IndexOf("value");
                        index5 = line.IndexOf("\"", index4);
                        index6 = line.IndexOf("\"", index5 + 1);
                        t2 = line.Substring(index5 + 1, index6 - index5 - 1);
                        if (t2.Contains(" "))
                        {
                            t2 = t2.Replace(" ", "+");
                        }
                    }
                    else
                    {
                        t2 = "";
                    }
                    if (C == 0)
                    {
                        Console.Write(t1 + "=" + t2);
                    }
                    else 
                    {
                        Console.Write("&" + t1 + "=" + t2);
                    }
                    C++;
                }
            }
            reader.Close();
        }
    }
}

