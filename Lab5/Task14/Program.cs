using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
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
            if (X < 5 && X> -3)
            {
                Console.WriteLine(X);
            }
            if (Y < 5 && Y > -3)
            {
                Console.WriteLine(Y);
            }
            if (Z < 5 && Z > -3)
            {
                Console.WriteLine(Z);
            }
        }
    }
}
