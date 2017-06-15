using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            string t = Console.ReadLine();
            string[] arr = t.Split(' ');
            int l = arr.Length;
            int mult = 1;
            int i = l-1;
            int C;
            while (i >=0)
            {
                C=int.Parse(arr[i]);
                mult = M * C;
                Console.Write(mult + " ");
                i--;
            }

        }
    }
}
