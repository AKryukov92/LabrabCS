using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task4147
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
        public bool Intersects(Interval i)
        {
            if (i.a > this.b|| i.b < this.a)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
