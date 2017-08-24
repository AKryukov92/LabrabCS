using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task1457
{
    public class Comparator1457 : Comparer<Point>
    {
        public Point Target { private set; get; }
        public int Count { private set; get; }
        public Comparator1457(Point p)
        {
            if (p == null)
            {
                ArgumentException error = new ArgumentException("Целевая точка не инициализирована");
                throw error;
            }
            this.Target = p;
        }
        public override int Compare(Point x, Point y)
        {
            if(x==null || y==null)
            {
                ArgumentException error = new ArgumentException("Конечная точка не инициализирована");
                throw error;
            }
            if (x.distanceTo(Target)>y.distanceTo(Target))
            {
                Count++;
                return 1;
            }
            else
            {
                Count++;
                return -1;
            }
        }
    }
}
