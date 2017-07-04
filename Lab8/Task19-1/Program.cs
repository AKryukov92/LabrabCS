using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            string[] sarr = t.Split(' ');
            int i = 0;
            int L = sarr.Length;
            int[] arr = new int[L];
            int R;
            while (i < L)
            {
                arr[i] = int.Parse(sarr[i]);
                i++;
            }
            i = 0;
            int C = arr[0];
            while (i < L)
            {
                if (arr[i]<C)
                {
                    C = arr[i];
                }
                i++;
            }
            i = 0;
            while (i < L)
            {
                R = arr[i] - C;
                Console.Write(R + " ");
                i++;
            }
        }
    }
}
