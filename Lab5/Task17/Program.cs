using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, p;
            String t;
            t = Console.ReadLine();
            m = int.Parse(t);
            t = Console.ReadLine();
            p = int.Parse(t);
            if (p==0)
            {
                Console.WriteLine("Значение P должно быть не равно нулю");
                return;
            }
            if (m%p==0)
            {
                Console.WriteLine(m/p);
            } else {
                Console.WriteLine("M не делится нацело на P");
            }
        }
    }
}
