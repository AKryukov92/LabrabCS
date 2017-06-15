using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string t1 = Console.ReadLine();
            string[] left=t1.Split(' ');
            string t2 = Console.ReadLine();
            string[] right = t2.Split(' ');
            int mult = 1;
            int i = 0;
            int L;
            int R;
            int l1 = left.Length;
            int l2 = right.Length;
            if (l1 != l2)
            {
                Console.WriteLine("Размеры массивов должны быть одинаковы");
                return;
            }
            while (i<l1)
            {
                L = int.Parse(left[i]);
                R = int.Parse(right[i]);
                mult = L * R;
                Console.Write(mult + " ");
                i++;
            }
        }
    }
}
