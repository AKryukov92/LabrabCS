using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task2401
{
    public class Interval
    {
        public int a;
        public int b;
        public int squeeze(int x)
        {
            if (a > b)
            {
                InvalidOperationException error = new InvalidOperationException("Корректность интервала была нарушена");
                throw error;
            }
            if (x >= b-a)
            {
                ArgumentException error = new ArgumentException("Невозможно уменьшить интервал на указанную длину");
                throw error;
            }
            b = b - x;
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
