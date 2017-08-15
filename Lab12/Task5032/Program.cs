using Classes.task5032;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5032
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
            Rectangle r = new Rectangle(100, 100, 100, 100);
            string[] sarr;
            int i=0;
            int z;//значение, передаваемое в метод
            do
            {
                string line = reader.ReadLine();
                sarr = line.Split(';');
                    if (sarr.Length != 2)
                    {
                        Console.WriteLine("Некорректный формат");
                        return;
                    }
                    z = int.Parse(sarr[1]);
                    if (sarr[0] == "shiftX")
                    {

                        if (r.Xn + z < 0)
                        {
                            Console.WriteLine("действий:" + i + "Координата X должна быть неотрицательной");
                            reader.Close();
                            return;
                        }
                        else
                        {
                            r.shiftX(z);
                        }
                    }
                else
                    if (sarr[0] == "shiftY")
                    {

                        if (r.Yn + z < 0)
                        {
                            Console.WriteLine("действий:" + i + "Координата Y должна быть неотрицательной");
                            reader.Close();
                            return;
                        }
                        else
                        {
                            r.shiftY(z);
                        }
                    }
                else
                    if (sarr[0] == "stretchX")
                    {

                        if (r.W + z <= 0)
                        {
                            Console.WriteLine("действий:" + i + "Ширина должна быть положительной");
                            reader.Close();
                            return;
                        }
                        else
                        {
                            r.stretchX(z);
                        }
                    }
                else
                    if (sarr[0] == "stretchY")
                    {

                        if (r.H + z <= 0)
                        {
                            Console.WriteLine("действий:" + i + "Высота должна быть положительной");
                            reader.Close();
                            return;
                        }
                        else
                        {
                            r.stretchY(z);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректное действие: " + sarr[0]);
                        return;
                    }
                    i++;
            }
            while (!reader.EndOfStream);
            Console.WriteLine("действий:" + i + r);
            reader.Close();
        }
    }
}
