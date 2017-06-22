using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task24
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            string[] sarr = t.Split();
            int L = sarr.Length;
            int[] arr = new int[L];
            int[] count = new int[L];
            int i = 0;
            int j = 0;
            int k = 0;
            int c = 0;
            while (k < L)
            {
                arr[k] = int.Parse(sarr[k]);//преобразование строкового массива в числовой
                k++;
            }
            while (i < L)//сколько раз число встречается в массиве
            {
                c = 0;
                j = 0;
                while (j < L)
                {
                    if (arr[i] == arr[j])
                    {
                        c = c + 1;
                    }
                    j++;
                }
                count[i] = c;
                i++;
            }
            i = 0;
            while (i < L)
            {
                Console.Write(count[i] + " ");
                i++;
            }
        }
    }
}
