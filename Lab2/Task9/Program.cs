using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            int a;
            a = int.Parse(t);
            int m;
            m = a % 360;//Остаток от деления
            Console.WriteLine(m);
        }
    }
}
