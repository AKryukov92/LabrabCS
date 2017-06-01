using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            int x = int.Parse(t);
            int i=10;
            while (i <= 20)
            {
                if (i == x)
                {
                    Console.WriteLine(i + "+");
                }
                else
                {
                    Console.WriteLine(i);
                }
                i = i + 1;
            }
        }
    }
}
