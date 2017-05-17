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
            string cx, cy, r, fill;
            cx = Console.ReadLine();
            cy = Console.ReadLine();
            r = Console.ReadLine();
            fill= Console.ReadLine();
            Console.WriteLine("<circle cx=\"{0}\" cy=\"{1}\" r=\"{2}\" fill=\"{3}\"/>", cx, cy, r, fill);
        }
    }
}
