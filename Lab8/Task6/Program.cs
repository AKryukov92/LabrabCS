using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int B = int.Parse(Console.ReadLine());
            int E = int.Parse(Console.ReadLine());
            string t = Console.ReadLine();
            string[] arr = t.Split(' ');
            int l=arr.Length;
            if (B < 0 || B >= l)
            {
                Console.WriteLine("Число B должно быть в интервале [0, {0})", l);
                return;
            }
            if (E < 0 || E >= l)
            {
                Console.WriteLine("Число E должно быть в интервале [0, {0})", l);
                return;
            }
            if (B < E)
            {
                while (B <= E)
                {
                    Console.Write(arr[B] + " ");
                    B++;
                }
            }
            else
            {
                while (E<=B)
                {
                    Console.Write(arr[E] + " ");
                    E++;
                }
            }

        }
    }
}
