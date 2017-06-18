using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            string[] arr = t.Split(' ');
            string M = arr.Min();
            int N = int.Parse(M);
            int i = 0;
            int L = arr.Length;
            int R, C;
            while (i < L)
            {
                C = int.Parse(arr[i]);
                R = C - N;
                Console.Write(R + " ");
                i++;
            }
        }
    }
}
