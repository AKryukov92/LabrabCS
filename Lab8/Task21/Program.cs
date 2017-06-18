using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            string X = Console.ReadLine();
            string Y = Console.ReadLine();
            string T = Console.ReadLine();
            string[] sarr = T.Split();
            int L = sarr.Length;
            int i = 0;
            while (i < L)
            {
                if (sarr[i] == X)
                {
                    sarr[i] = Y;
                }
                Console.Write(sarr[i] + " ");
                i++;
            }
        }
    }
}
