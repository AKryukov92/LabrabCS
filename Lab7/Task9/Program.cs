using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            string t1 = t.Substring(0, 1);
            if (t1 == "s")
            {
                Console.WriteLine(t.ToLower());
                return;
            }
            if (t1 == "U")
            {
                Console.WriteLine(t.ToUpper());
            }
            else
            {
                Console.WriteLine(t);
            }
        }
    }
}
