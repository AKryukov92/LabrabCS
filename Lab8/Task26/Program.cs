using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task26
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
            int a = 0;
            while (k < L)
            {
                arr[k] = int.Parse(sarr[k]);//преобразование строкового массива в числовой
                k++;
            }
            i = 0;
            j = 0;
            int q = 0;//Количество повторений
            while (j < L)
            {
                i = j + 1;
                while (i < L)
                {
                    if (arr[j] == arr[i] && i!=j)
                    {
                        q = q + 1;
                        break;
                    }
                    i++;
                }
                j++;
            }
            Console.WriteLine(L-q);
        }
    }
}
