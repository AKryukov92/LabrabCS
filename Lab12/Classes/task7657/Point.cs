using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task7657
{
    public class Point
    {
        public int x;
        public int y;
        public string color;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(int x, int y, string color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }
        public String print()
        {
            return "(" + x + ";" + y + ")";
        }
        public override bool Equals(Object o)
        {
            if (this == o) return true;
            if (o == null || GetType() != o.GetType()) return false;

            Point point = (Point)o;

            if (x != point.x) return false;
            return y == point.y;
        }
        public override int GetHashCode()
        {
            int result = x;
            result = 31 * result + y;
            return result;
        }
        public override string ToString()
        {
            return String.Format("{{\"x\":{0}, \"y\":{1}, \"color\":\"{2}\"}}", x, y, color);
        }
    }
}
