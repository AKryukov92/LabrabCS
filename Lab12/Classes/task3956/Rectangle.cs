using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task3956
{
    public class Rectangle : Shape
    {
        public int Xn;
        public int Yn;
        public int W;
        public int H;
        public string stroke;
        public string fill;
        public int strokeWidth;
        public Rectangle(int Xn, int Yn, int W, int H)
        {
            this.Xn = Xn;
            this.Yn = Yn;
            this.H = H;
            this.W = W;
        }
        public Rectangle(int Xn, int Yn, int W, int H, string stroke, string fill, int strokeWidth)
        {
            this.Xn = Xn;
            this.Yn = Yn;
            this.H = H;
            this.W = W;
            this.stroke = stroke;
            this.strokeWidth = strokeWidth;
            this.fill = fill;
        }
        public override String ToString()
        {
            return String.Format("<rect x='{0}' y='{1}' width='{2}' height='{3}' stroke='{4}' stroke-width='{5}' fill='{6}'/>", Xn, Yn, W, H, stroke, strokeWidth, fill);
        }
        public override Point getCenter()
        {
            return new Point(Xn+W/2, Yn+H/2);
        }
        public override double area()
        {
            return H*W;
        }
        public override void slide(int dx, int dy)
        {
            Xn=Xn + dx;
            Yn=Yn + dy;
        }
    }
}
