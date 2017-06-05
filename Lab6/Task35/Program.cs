using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task35
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int h=int.Parse(Console.ReadLine());
            int j = 0;
            int i = 0;
            while (i < h)
            {
                i++;
                while (j < i)
                {
                    Console.Write(s);
                    j++;
                }
                j = 0;
                Console.WriteLine();
            }
        }
    }
}
