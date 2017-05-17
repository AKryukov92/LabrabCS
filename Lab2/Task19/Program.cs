using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2, t3;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            t3 = Console.ReadLine();
            double V0;
            V0 = double.Parse(t1);
            double t;
            t = double.Parse(t2);
            double a;
            a = double.Parse(t3);
            double R;
            R = V0*t+a*t*t/2;
            Console.WriteLine("{0:F4}", R);
        }
    }
}
