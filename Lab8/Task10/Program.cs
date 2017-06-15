using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int S = int.Parse(Console.ReadLine());
            string t = Console.ReadLine();
            string[] arr = t.Split(' ');
            int l = arr.Length;
            int i = S%l;
            int j = 0;
            if (S >= 0)
            {
                while (i > 0)
                {
                    Console.Write(arr[l - i] + " ");
                    i--;
                }
                i = S % l;
                while (j < l - i)
                {
                    Console.Write(arr[j] + " ");
                    j++;
                }
            }
            else
            {
                i = -1 * i;
                while (i < l)
                {
                    Console.Write(arr[i] + " ");
                    i++;
                }
                i = - 1 * S % l;
                while (j < i)
                {
                    Console.Write(arr[j] + " ");
                    j++;
                }            
            }
        }
    }
}
