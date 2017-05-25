using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            double m;
            m = double.Parse(t1);
            double a, b;
            a = double.Parse(t2);
            b = a * Math.PI / 180;//Угол в радианах
            double g = 9.8067;
            double R;
            R=m*g*Math.Cos(b);
            Console.WriteLine("{0:F4}", R);
        }
    }
}
