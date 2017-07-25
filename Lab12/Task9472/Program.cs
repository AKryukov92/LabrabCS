using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9472
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
            double a, b, r;
            double S=0;
            double S0 = 0;
            try
            {
                do
                {
                    string line = reader.ReadLine();
                    string[] sarr = line.Split(';');
                    if (sarr[0] != "rect" && sarr[0] != "circle")
                    {
                        Console.WriteLine("Сообщение об ошибке");
                        return;
                    }
                    if (sarr[0] == "rect")
                    {
                        if (sarr.Length != 5)
                        {
                            Console.WriteLine("Некорректный формат данных");
                            return;
                        }
                        a = double.Parse(sarr[3]);
                        b = double.Parse(sarr[4]);
                        S = a * b;
                    }
                    if (sarr[0] == "circle")
                    {
                        if (sarr.Length != 4)
                        {
                            Console.WriteLine("Некорректный формат данных");
                            return;
                        }
                        r = double.Parse(sarr[3]);
                        S = Math.PI*r*r;
                    }
                    if (S > S0)
                    {
                        S0 = S;
                    }
                }
                while (!reader.EndOfStream);
                Console.WriteLine("{0:F4}", S0);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Не удается считать число");
            }
            reader.Close();
        }
    }
}
