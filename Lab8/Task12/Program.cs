using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            int B = int.Parse(Console.ReadLine());
            string t = Console.ReadLine();
            string[] arr = t.Split(' ');
            int l = arr.Length;
            if (B < 0 || B >= l)
            {
                Console.WriteLine("Число B должно быть в интервале [0, {0})", l);
                return;
            }
            int A = int.Parse(arr[B]);
            int C;
            int i=0;
            int count = 0;
            while (i < l)
            {
                C = int.Parse(arr[i]);
                if (C < A)
                {
                    count = count + 1;
                }
                i++;
            }
            Console.WriteLine(count);
        }
    }
}
