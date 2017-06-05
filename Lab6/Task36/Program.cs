using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task36
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int i = 1;
            int count=0;// количество чисел 
            if (A < B)
            {
                if (A % 2 == 0)
                {
                    A = A + 1;
                    Console.Write(A);
                    while (A < B)
                    {
                        A = A + 2;
                        if (A > B)
                        { return; }
                        Console.WriteLine();
                        count = count + 1;
                        while (i <= count)
                        {
                            Console.Write(".");
                            i++;
                        }
                        i = 1;
                        Console.Write(A);
                    }
                }
                else
                {
                    Console.Write(A);
                    while (A < B)
                    {
                        A = A + 2;
                        if (A >= B)
                        { return; }
                        Console.WriteLine();
                        count = count + 1;
                        while (i <= count)
                        {
                            Console.Write(".");
                            i++;
                        }
                        i = 1;
                        Console.Write(A);
                    }
                }
            }
            else
            {
                if (B % 2 == 0)
                {
                    B = B + 1;
                    Console.Write(B);
                    while (B < A)
                    {
                        B=B + 2;
                        if (B > A)
                        { return; }
                        Console.WriteLine();
                        count = count + 1;
                        while (i <= count)
                        {
                            Console.Write(".");
                            i++;
                        }
                        i = 1;
                        Console.Write(B);
                    }
                }
                else
                {
                    Console.Write(B);
                    while (B < A)
                    {
                        B=B + 2;
                        if (B > A)
                        { return; }
                        Console.WriteLine();
                        count = count + 1;
                        while (i <= count)
                        {
                            Console.Write(".");
                            i++;
                        }
                        i = 1;
                        Console.Write(B);
                    }
                }
            }
        }
    }
}
