using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task38
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int i = 0;
            int count = 0;
            if (A < B)
            {
                if (A % 2 == 0)
                {
                    A = A + 1;
                    while (A <= B)
                    {
                        while (i <= count)
                        {
                            Console.Write(A + ",");
                            i++;
                        }
                        count = count + 1;
                        A = A + 2;
                        if (B - A <= 1)
                        {
                            Console.Write(A);
                            return;
                        }
                    }
                }
                else
                {
                    while (A <= B)
                    {
                        while (i <= count)
                        {
                            Console.Write(A + ",");
                            i++;
                        }
                        count = count + 1;
                        A = A + 2;
                        if (B - A <= 1)
                        {
                            Console.Write(A);
                            return;
                        }
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
                        while (i <= count)
                        {
                            Console.Write(A + ",");
                            i++;
                        }
                        count = count + 1;
                        A = A - 2;
                        if (A - B <= 1)
                        {
                            Console.Write(A);
                            return;
                        }
                    }
                }
                else
                {
                    while (B <= A)
                    {
                        while (i <= count)
                        {
                            Console.Write(A + ",");
                            i++;
                        }
                        count = count + 1;
                        A= A - 2;
                        if (A - B <= 1)
                        {
                            Console.Write(A);
                            return;
                        }
                    }
                }
            }

        }
    }
}
