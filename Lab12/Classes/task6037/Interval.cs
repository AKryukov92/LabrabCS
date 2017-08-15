using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task6037
{
    public class Interval
    {
        public int a;
        public int b;
        public static bool HasIntersection(Interval l, Interval r)
        {
            if (l.a > l.b)
            {
                InvalidOperationException error = new InvalidOperationException("Корректность интервала была нарушена");
                throw error;
            }
            if (r.a > r.b)
            {
                InvalidOperationException error = new InvalidOperationException("Корректность интервала была нарушена");
                throw error;
            }
            if (r.a > l.b || r.b < l.a)
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
