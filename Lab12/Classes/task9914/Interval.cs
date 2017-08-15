using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task9914
{
    public class Interval
    {
        public int a;
        public int b;
        public bool Intersects(Interval r)
        {
            if (r == null)
            {
                ArgumentException error = new ArgumentException("Данный интервал не инициализирован");
                throw error;
            }
            if (r.a>r.b)
            {
                ArgumentException error = new ArgumentException("Некорректный интервал");
                throw error;
            }
            if (a>b)
            {
                InvalidOperationException error = new InvalidOperationException("Корректность интервала была нарушена");
                throw error;
            }
            
            if (r.a > b || r.b < a)
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
