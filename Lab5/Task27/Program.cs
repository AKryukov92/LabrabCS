using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task27
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            int a = int.Parse(t);
            int b=a%10;
            if (a >100 || a<-10)
            {
                Console.WriteLine("Значение A должно быть в интервале [-10, 100]");
                return;
            }
            if (a == 40)
            {
                Console.WriteLine("{0}'ой", a);
                return;
            } 
            if (b==1 || b==4 || b==5 || b == 9 || b==0)
            {
                Console.WriteLine("{0}'ый", a);
                return;
            }
            if (b == 2 || b == 6 || b == 7 || b == 8)
            {
                Console.WriteLine("{0}'ой", a);
                return;
            }
            if (b == 3)
            {
                Console.WriteLine("{0}'ий", a);
                return;
            }

        }
    }
}
