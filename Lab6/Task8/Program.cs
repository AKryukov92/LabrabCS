using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 1;//фунты
            double g; //граммы
            while (f <= 20)
            {
                g = f * 453;//граммы
                if (f <= 9)
                {
                    Console.WriteLine(f + "   " + g);
                }
                else
                {
                    Console.WriteLine(f + "  " + g);
                }
                f = f + 1;
            }
        }
    }
}
