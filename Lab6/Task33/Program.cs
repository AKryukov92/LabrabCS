using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task33
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int i = 1;
            int j=1;
            if (w < 0)
            {
                Console.WriteLine("Значение W должно быть неотрицательно");
                return;
            }
            while (i <=3)
            {
                if (i == 1 || i == 3)
                {
                    Console.Write("+");
                    while (j <= w)
                    {
                        Console.Write("-");
                        j++;
                    }
                    Console.Write("+");
                    Console.WriteLine();
                    j = 1;
                }
                else
                {
                    Console.Write("|");
                    while (j <= w)
                    {
                        Console.Write(".");
                        j++;
                    }
                    Console.Write("|");
                    Console.WriteLine();
                    j = 1;
                }
                i++;
            }
        }
    }
}
