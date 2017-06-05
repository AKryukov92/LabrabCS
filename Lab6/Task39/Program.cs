using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task39
{
    class Program
    {
        static void Main(string[] args)
        {
            int P = int.Parse(Console.ReadLine());
            int Q = int.Parse(Console.ReadLine());
            int C = (P + Q) / 2;//середина строчки
            if (P < Q)
            {               
                while (P<C)
                {
                    Console.Write(P + "<");
                    P = P + 1;
                }
                while (P <Q) 
                {
                    Console.Write(P + ">");
                    P = P + 1;
                }
                if (P == Q)
                {
                    Console.Write(P);
                }
            }
            else
            {
                while (Q < C)
                {
                    Console.Write(Q + "<");
                    Q = Q + 1;
                }
                while (Q < P)
                {
                    Console.Write(Q + ">");
                    Q = Q + 1;
                }
                if (Q == P)
                {
                    Console.Write(Q);
                }
              
            }
                
        }
    }
}
