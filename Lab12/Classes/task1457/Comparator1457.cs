using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task1457
{
    public class Comparator1457 : Comparer<Point>
    {
        public Point p;
        public int i;
        public Comparator1457(Point p)
        {
            if (p == null)
            {
                ArgumentException error = new ArgumentException("Целевая точка не инициализирована");
                throw error;
            }
            this.p = p;
        }
        public override int Compare(Point x, Point y)
        {
            if(x==null || y==null)
            {
                ArgumentException error = new ArgumentException("Конечная точка не инициализирована");
                throw error;
            }
            if (x.distanceTo(p)>y.distanceTo(p))
            {
                i++;
                return 1;
            }
            else
            {
                i++;
                return -1;
            }
        }
        public int getCount()
        {
            return i;
        }
        public Point getTarget()
        {
            return p;
        }
    }
}
