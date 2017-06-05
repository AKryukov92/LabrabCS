using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task34
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int i = 0;
            int j = 0;
            if (w < 0)
            {
                Console.WriteLine("Значение W должно быть неотрицательно");
                return;
            }
            if (h < 0)
            {
                Console.WriteLine("Значение H должно быть неотрицательно");
                return;
            }
            Console.Write(" ");
            while (j < w)
            {
                Console.Write(j);
                j++;
            }
            Console.WriteLine();
            while (i < h)
            {
                Console.Write(i);
                j = 0;
                while (j < w)
                {
                    Console.Write(" ");
                    j++;
                }
                Console.Write("|");
                Console.WriteLine();
                i++;
                if (i == h)
                {
                    j = 0;
                    Console.Write(" ");
                    while (j < w)
                    {
                        Console.Write("-");
                        j++;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
