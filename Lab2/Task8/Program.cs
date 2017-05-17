using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1;
            t1 = Console.ReadLine();
            String t2;
            t2 = Console.ReadLine();
            int a;
            a = int.Parse(t1);
           int b;
            b = int.Parse(t2);
            int q, p;
            q = (a * 100) / b;
            p = a * 100 % b;//Остаток от деления
            Console.WriteLine("{0} шт. и {1} см", q, p);
        }
    }
}
