﻿using System;
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
            int i=l-1;
            int j = 0;
            string A;
            A = arr[i];
            while (i>0)
            {
                arr[i] = arr[i - 1];
                i--;
            }
            arr[0] = A;
            while (j < l)
            {
                Console.Write(arr[j] + " ");
                j++;
            }
        }
    }
}
