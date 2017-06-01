using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task27
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int i = 1;
            if (w < 0 || w > 20)
            {
                Console.WriteLine("Значение W должно быть в интервале [0, 20]");
                return;
            } 
            while (i <= w)
            {
                Console.Write("a");
                i++;
            }
            Console.WriteLine();
            i = 1;
            while (i <= w)
            {
                Console.Write("b");
                i++;
            }
            Console.WriteLine();
            i = 1;
            while (i <= w)
            {
                Console.Write("c");
                i++;
            }
            Console.WriteLine();
            i = 1;
            while (i <= w)
            {
                Console.Write("d");
                i++;
            }
            Console.WriteLine();
            i = 1;
            while (i <= w)
            {
                Console.Write("e");
                i++;
            }
            Console.WriteLine();
            i = 1;
            while (i <= w)
            {
                Console.Write("f");
                i++;
            }
            Console.WriteLine();
            i = 1;
            while (i <= w)
            {
                Console.Write("g");
                i++;
            }
            Console.WriteLine();
            i = 1;
            while (i <= w)
            {
                Console.Write("h");
                i++;
            }
            Console.WriteLine();
        }
    }
}
