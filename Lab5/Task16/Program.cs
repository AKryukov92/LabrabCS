using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            String t;
            t = Console.ReadLine();
            x = double.Parse(t);
            t = Console.ReadLine();
            y = double.Parse(t);
            t = Console.ReadLine();
            z = double.Parse(t);
            if (x>y&&x>z)
            {
                Console.WriteLine(x);
                return;
            }
            if (y>x&&y>z)
            {
                Console.WriteLine(y);
                return;
            }
            if (z>x&&z>y)
            {
                Console.WriteLine(z);
                return;
            }
        }
    }
}
