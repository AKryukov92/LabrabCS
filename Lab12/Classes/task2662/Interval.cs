using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task2662
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
        public override bool Equals(Object o)
        {
            if (this == o) return true;
            if (o == null || GetType() != o.GetType()) return false;

            Interval interval = (Interval)o;

            if (a != interval.a) return false;
            return b == interval.b;
        }
    }
}
