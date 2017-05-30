using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y, Z;
            String t;
            t = Console.ReadLine();
            X = double.Parse(t);
            t = Console.ReadLine();
            Y = double.Parse(t);
            t = Console.ReadLine();
            Z = double.Parse(t);
            if (X==Y || Y==Z || X==Z)
            {
                Console.WriteLine("Среди чисел есть равные");
            }
            else
            {
                Console.WriteLine("Числа не равны друг другу.");
            }
        }
    }
}
