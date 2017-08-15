using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task6876
{
    public class Rectangle : Shape
    {
        public int Xn;
        public int Yn;
        public int W;
        public int H;
        public string stroke;
        public int strokeWidth;
        public string fill;
        public Rectangle(int Xn, int Yn, int W, int H)
        {
            this.Xn = Xn;
            this.Yn = Yn;
            this.H = H;
            this.W = W;
            this.stroke = "black";
            this.strokeWidth = 1;
            this.fill = "transparent";
        }
        public override String ToString()
        {
            return String.Format("<rect x='{0}' y='{1}' width='{2}' height='{3}' stroke='{4}' stroke-width='{5}' fill='{6}'/>", Xn, Yn, W, H, stroke, strokeWidth, fill);
        }
        public override double area()
        {
            return H * W;
        }
    }
}
