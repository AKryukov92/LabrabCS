using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            string[] sarr;
            sarr = t.Split(' ');
            int l = sarr.Length;
            int i=0;
            while (i < l)
            {
                Console.WriteLine(sarr[i] + "  " +i);
                i++;
            }
        }
    }
}
