using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task1953
{
    public class Interval
    {
        public int a;
        public int b;
        public Interval(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public String print()
        {
            return "[" + a + ";" + b + "]";
        }
    }
}
