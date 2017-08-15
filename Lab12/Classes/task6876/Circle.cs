using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task6876
{
    public class Circle : Shape
    {
        public int cx;
        public int cy;
        public int r;
        public string stroke;
        public int strokeWidth;
        public string fill;
        public Circle(int cx, int cy, int r)
        {
            this.cx = cx;
            this.cy = cy;
            this.r = r;
            this.stroke = "black";
            this.strokeWidth = 1;
            this.fill = "transparent";
        }
        public override String ToString()
        {
            return String.Format("<circle cx='{0}' cy='{1}' r='{2}' stroke='{3}' stroke-width='{4}' fill='{5}'/>", cx, cy, r, stroke, strokeWidth, fill);
        }
        public override double area()
        {
            return r * r * Math.PI;
        }
    }
}
