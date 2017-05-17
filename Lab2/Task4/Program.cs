using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double r;
            r = double.Parse(t);
            double c;
            c = 2 * Math.PI * r;
            Console.WriteLine("{0:F4}", c);
        }
    }
}
