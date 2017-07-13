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
            string[] sarr = t.Split(' ');
            int L = sarr.Length;
            int[] arr = new int[L];
            if (P < 0 || P>=L)
            {
                Console.WriteLine("Число P должно быть в интервале [0, {0})", L);
                return;
            }
            if (Q<0 || Q>=L)
            {
                Console.WriteLine("Число Q должно быть в интервале [0, {0})", L);
                return;
            }
            int i = 0;
            while (i < L)
            {
                arr[i] = int.Parse(sarr[i]);
                i++;
            }
            i = 0;
            int M = arr[P];
            while (P <= Q)
            {
                if (arr[P] < M)
                {
                    M = arr[P];
                }
                P++;
            }
            Console.WriteLine(M);
        }
    }
}
