using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int P = int.Parse(Console.ReadLine());
            int Q = int.Parse(Console.ReadLine());
            string t = Console.ReadLine();
            string[] arr = t.Split(' ');
            int l = arr.Length;
            int i = 0;
            string A;
            if (P < 0 || P >= l)
            {
                Console.WriteLine("Число P должно быть в интервале [0, {0})", l);
                return;
            }
            if (Q < 0 || Q >= l)
            {
                Console.WriteLine("Число Q должно быть в интервале [0, {0})", l);
                return;
            }
            A = arr[P];
            arr[P] = arr[Q];
            arr[Q] = A;
            while (i<l)
            {
                Console.Write(arr[i] + " ");
                i++;
            }
        }
    }
}
