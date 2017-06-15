using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            string[] arr = t.Split(' ');
            int l = arr.Length;
            int i=0;
            Console.Write(arr[l - 1] + " ");
            while (i < l-1)
            {
                Console.Write(arr[i] + " ");
                i++;
            }
        }
    }
}
