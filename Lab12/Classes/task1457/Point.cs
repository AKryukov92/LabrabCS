using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task1457
{
    public class Point 
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public String print()
        {
            return "(" + x + ";" + y + ")";
        }
        public override string ToString()
        {
            return "(" + x + ";" + y + ")";
        }
        public double distanceTo(Point p)
        {
            int dx = p.x - x;
            int dy = p.y - y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }  
}
