using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            string[] sarr = t.Split();
            int L = sarr.Length;
            int[] arr=new int[L];
            int i = 0;
            while (i < L)
            {
                arr[i] = int.Parse(sarr[i]);
                i++;
            }
            Array.Sort(arr);
            i = 0;
            while (i < L)
            {
                Console.Write(arr[i] + " ");
                i++;
            }
        }
    }
}
