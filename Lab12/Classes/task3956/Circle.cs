using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task3956
{
    public class Circle : Shape
    {
        public int cx;
        public int cy;
        public int r;
        public string stroke;
        public string fill;
        public int strokeWidth;
        public Circle(int cx, int cy, int r)
        {
            this.cx = cx;
            this.cy = cy;
            this.r = r;
        }
        public Circle(int cx, int cy, int r, string stroke, string fill, int strokeWidth)
        {
            this.cx = cx;
            this.cy = cy;
            this.r = r;
            this.stroke = stroke;
            this.strokeWidth = strokeWidth;
            this.fill = fill;
        }
        public override String ToString()
        {
            return String.Format("<circle cx='{0}' cy='{1}' r='{2}'stroke='{3}' stroke-width='{4}' fill='{5}'/>", cx, cy, r, stroke, strokeWidth, fill);
        }
        public override Point getCenter()
        {
            return new Point(cx, cy);
        }
        public override double area()
        {
            return r*r*Math.PI;
        }
        public override void slide(int dx, int dy)
        {
            cx=cx + dx;
            cy=cy + dy;
        }
    }
}
