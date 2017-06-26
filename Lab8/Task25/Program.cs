using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            string[] sarr = t.Split();
            int L = sarr.Length;
            int[] arr = new int[L];
            int i = 0;
            int j = 0;
            int k = 0;
            int s = 0;
            while (k < L)
            {
                arr[k] = int.Parse(sarr[k]);//преобразование строкового массива в числовой
                k++;
            }
            while (i < L)
            {
                j = i+1;
                while (j < L)
                {
                    if (arr[i] == arr[j] && i != j)
                    {
                        s = s + 1;//количество повторений
                        break;
                    }
                    j++;
                }
                i++;
            }
            Console.WriteLine(s);
            int L2 = L - s;//длина нового массива
            int[] arr2 = new int[L2];
            i = 0;
            j = 0;
            int r = 0;//сколько чисел записано в новый массив
            int q = 0;//Количество повторений
            while (j < L)
            {
                i = 0;
                q = 0;
                while (i < r)
                {
                    if (arr[j] == arr2[i])
                    {
                        q = q + 1;
                    }
                    i++;
                }
                if (q == 0)
                {
                    Console.WriteLine("+");
                    arr2[r] = arr[j];
                    r++;

                }
                j++;
            }



            k = 0;
            while (k<L2)
            {
                Console.Write(arr2[k] + " ");
                k++;
            }

            Console.WriteLine("простой вариант:");
            int[] arr3 = arr.Distinct().ToArray();
            Console.WriteLine(String.Join(" ", arr3));
        }
    }
}




        
    

