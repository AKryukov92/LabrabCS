using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            string[] sarr = t.Split();
            int L = sarr.Length;
            int[] arr = new int[L];
            int k = 0;
            while (k < L)
            {
                arr[k] = int.Parse(sarr[k]);//преобразование строкового массива в числовой
                k++;
            }
            int x = 0;//сортировка методом "пузырька"
            for (int i = 0; i < L - 1; i++)
            {
                for (int j = i + 1; j < L; j++)
                {
                    if (arr[i] >= arr[j])
                    {
                        x = arr[i];
                        arr[i] = arr[j];
                        arr[j] = x;
                    }
                }
            }
            int u = 0;
            while (u < L)
            {
                Console.Write(arr[u] + " ");
                u++;
            }
        }
    }
}
