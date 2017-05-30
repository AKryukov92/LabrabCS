using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            double x, y;
            t = Console.ReadLine();
            x = double.Parse(t);
            t = Console.ReadLine();
            y = double.Parse(t);
            if (x>=2 && y>=0 || x>=1 && y<=-1)
            {
                Console.WriteLine("Точка ({0};{1}) принадлежит множеству", x, y);
            }
            else
            {
                Console.WriteLine("Точка ({0};{1}) не принадлежит множеству", x, y);
            }
        }
    }
}
