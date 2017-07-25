using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Methods;

namespace Task1212_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            try
            {
                string filename = Lab13.checkup(input);
                int a, b, S;
                int S0 = 0;
                StreamReader reader = new StreamReader(filename);
                    try
                    {
                        do
                        {
                            string line = reader.ReadLine();
                            string[] sarr = line.Split(';');
                            if (sarr.Length != 4)
                            {
                                Console.WriteLine("Некорректный формат данных");
                                return;
                            }
                            a = int.Parse(sarr[2]);
                            b = int.Parse(sarr[3]);
                            S = a * b;
                            if (S > S0)
                            {
                                S0 = S;
                            }
                        }
                        while (!reader.EndOfStream);
                        Console.WriteLine(S0);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Не удается считать число");
                    }
                    reader.Close();
                }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
