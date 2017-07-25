using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5081
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string filename = "test" + input + ".txt";
            if (!File.Exists(filename))
            {
                Console.WriteLine("Файл отсутствует");
                return;
            }
            StreamReader reader = new StreamReader(filename);
            if (reader.EndOfStream)
            {
                Console.WriteLine("Файл пуст");
                return;
            }
            int sum;
            int i;
                do
                {
                    i = 0;
                    sum = 0;
                    string line = reader.ReadLine();
                    if (line == "")
                    {
                        Console.WriteLine("Строка пуста");
                    }
                    else
                    {
                        string[] sarr = line.Split(',');
                        try
                        {
                            while (i < sarr.Length)
                            {
                                sum = sum + int.Parse(sarr[i]);
                                i++;
                            }
                            Console.WriteLine(sum);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Не удается считать число");
                        }
                    }
                }
                while (!reader.EndOfStream);
            reader.Close();
        }
    }
}
