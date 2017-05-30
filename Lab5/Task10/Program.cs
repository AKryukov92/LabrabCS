using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y, Z;
            String t;
            t = Console.ReadLine();
            X = double.Parse(t);
            t = Console.ReadLine();
            Y = double.Parse(t);
            t = Console.ReadLine();
            Z = double.Parse(t);
            if (X >= 0)
            {
                Console.WriteLine(X*X);
            }
            else
            {
                Console.WriteLine(X);
            }
            if (Y >= 0)
            {
                Console.WriteLine(Y*Y);
            }
            else
            {
                Console.WriteLine(Y);
            }
            if (Z >= 0)
            {
                Console.WriteLine(Z*Z);
            }
            else
            {
                Console.WriteLine(Z);
            }
        }
    }
}
