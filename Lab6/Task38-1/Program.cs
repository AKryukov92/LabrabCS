using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = A;
            if (A < B)
            {
                if (A % 2 == 0)
                {
                    A = A + 1;
                        while (A <= B)
                        {
                            if (A==C+1)
                            {
                                Console.Write(A);
                            }
                            else
                            {
                                Console.Write(", " + A);
                            }
                            A = A + 2;
                        }
                    }
                else
                {
                    while (A <= B)
                    {
                        if (A == C)
                        {
                            Console.Write(A);
                        }
                        else
                        {
                            Console.Write(", " + A);
                        }
                        A = A + 2;
                    }
                }
            }
            else
            {
                if (A % 2 == 0)
                {
                    A = A - 1;
                    while (B <= A)
                    {
                        if (A == C-1)
                        {
                            Console.Write(A);
                        }
                        else
                        {
                            Console.Write(", " + A);
                        }
                        A = A - 2;
                    }
                }
                else
                {
                    while (B <= A)
                    {
                        if (A == C)
                        {
                            Console.Write(A);
                        }
                        else
                        {
                            Console.Write(", " + A);
                        }
                        A = A - 2;
                    }
                }
            }
        }
    }
}

