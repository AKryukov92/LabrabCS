using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task4147
{
    public class Rectangle
    {
        public int Xn;
        public int Yn;
        public int H;
        public int W;
        public Rectangle(int Xn, int Yn, int H, int W)
        {
            this.Xn = Xn;
            this.Yn = Yn;
            this.H = H;
            this.W = W;
        }
        public Rectangle(Point corner, int H, int W)
        {
            Xn = corner.Xt;
            Yn = corner.Yt; 
            this.H = H;
            this.W = W;
        }
        public Rectangle(Interval i1, Interval i2)
        {
            Xn = i1.a;
            Yn = i1.b;
            H = i2.a;
            W = i2.b;
        }
        public bool contains(Point p)
        {
            if (p.Xt >= Xn && p.Xt <= Xn + W && p.Yt >= Yn && p.Yt <= Yn + H)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int area()
        {
            return H*W;
        }
        public Interval getProjectionX()
        {
            return new Interval(Xn, Xn+W);
        }
        public Interval getProjectionY()
        {
            return new Interval(Yn, Yn + H);
        }
    }
}
