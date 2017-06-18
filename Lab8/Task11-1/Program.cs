using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            string[] arr = t.Split(' ');
            int l = arr.Length;
            int i = 0;
            int j = 0;
            string A;
            while (i < l / 2)
            {
                A = arr[i];
                arr[i] = arr[l - i - 1];
                arr[l - i - 1] = A;
                i++;
            }
            while (j < l)
            {
                Console.Write(arr[j] + " ");
                j++;
            }
        }
    }
}
