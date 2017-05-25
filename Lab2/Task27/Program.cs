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
            String t1;
            t1 = Console.ReadLine();
            double a, R;
            a = double.Parse(t1);
            R = Math.Sqrt(1-Math.Sin(a*Math.PI/180)*Math.Sin(a*Math.PI/180));
            Console.WriteLine("{0:F4}", R);
        }
    }
}
