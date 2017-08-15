using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task1953
{
    public class Circle
    {
        public int cx;
        public int cy;
        public int r;
        public Circle(int cx, int cy, int r)
        {
            this.cx = cx;
            this.cy = cy;
            this.r = r;
        }
        public override String ToString()
        {
            return String.Format("<circle cx=\"{0}\" cy=\"{1}\" r=\"{2}\"/>", cx, cy, r);
        }
        public double area()
        {
            return Math.PI*r*r;
        }
        public Interval getProjectionX()
        {
            return new Interval(cx-r, cx+r);
        }
        public Interval getProjectionY()
        {
            return new Interval(cy-r, cy+r);
        }
        
    }
}
