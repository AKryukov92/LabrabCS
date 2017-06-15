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
            string t = Console.ReadLine();
            string[] sarr;
            sarr = t.Split(' ');
            int l = sarr.Length;
            int i = l - 1;
            while (i>=0)
            {
                Console.Write(sarr[i] + " ");
                i--;
            }
        }
    }
}
