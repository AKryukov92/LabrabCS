using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task5242
{
    public class Interval
    {
        public int a;
        public int b;
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
