using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            string t=Console.ReadLine();
            string[] sarr;
            string raw = "a b c d e f g h";
            sarr = raw.Split(' ');
            int i = 0;
            int l = sarr.Length;
            while (i < l)
            {
                if (sarr[i] == t)
                {
                    Console.WriteLine(sarr[i] + "+");
                }
                else
                {
                    Console.WriteLine(sarr[i]);
                }
                i++;
            }
        }
    }
}
