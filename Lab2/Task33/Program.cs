using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task33
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1;
            t1 = Console.ReadLine();
            double h, S;
            h = double.Parse(t1);
            double r=6350;
            S = Math.Sqrt((r+h)*(r+h)-r*r);
            Console.WriteLine("{0:F4}", S);
        }
    }
}
