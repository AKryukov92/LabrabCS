using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            int P = int.Parse(Console.ReadLine());
            int Q = int.Parse(Console.ReadLine());
            string t = Console.ReadLine();
            string t1 = t.Substring(P*2, Q*2-P*2+1);
            string[] arr = t1.Split(' ');
            string M = arr.Min();
            int N = int.Parse(M);
            Console.WriteLine(N);
        }
    }
}
