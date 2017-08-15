using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task7297
{
    public class Interval
    {
        public int a;
        public int b;
        public bool contains(int x)
        {
            if (a > b)
            {
                InvalidOperationException error = new InvalidOperationException("Корректность интервала была нарушена");
                throw error;
            }
            if (x>=a && x<=b)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
