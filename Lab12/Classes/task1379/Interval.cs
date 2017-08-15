using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task1379
{
    public class Interval
    {
        public int a;
        public int b;
        public int slide(int x)
        {
            if (a > b)
            {
                InvalidOperationException error = new InvalidOperationException("Корректность интервала была нарушена");
                throw error;
            }
            a = a + x;
            b = b + x;
            return a;
            return b;
        }
        public String print()
        {
            if (a > b)
            {
                InvalidOperationException error = new InvalidOperationException("Корректность интервала была нарушена");
                throw error;
            }
            return "[" + a + ";" + b + "]";
        }
    }
}
