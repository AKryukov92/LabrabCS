using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c;
            String t;
            t = Console.ReadLine();
            a = double.Parse(t);
            t = Console.ReadLine();
            b = double.Parse(t);
            t = Console.ReadLine();
            c = double.Parse(t);
            if (a<b&&b<c)
            {
                Console.WriteLine("Выполняется");
            }
            else
            {
                Console.WriteLine("Не выполняется");
            }
        }
    }
}
