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
            string[] arr = t.Split(' ');
            string M = arr.Min();
            Console.WriteLine(M);
        }
    }
}
