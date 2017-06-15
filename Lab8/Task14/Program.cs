using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int[] arr = new int[] { 11, 13, 17, 19, 10, 12, 14, 15, 16, 18, 20 };
            int i = 0;
            int l = arr.Length;
            while (i < l)
            {
                if (arr[i] == X)
                {
                    Console.WriteLine(arr[i] + "+");
                }
                else
                {
                    Console.WriteLine(arr[i]);
                }
                i++;
            }
        }
    }
}
