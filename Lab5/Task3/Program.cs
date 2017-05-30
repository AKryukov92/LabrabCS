using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int K;
            String t;
            t = Console.ReadLine();
            K = int.Parse(t);
            if (K >= 0)
            {
                Console.WriteLine(Math.Sqrt(K));
            }
            else
            {
                Console.WriteLine(K*K);
            }
        }
    }
}
