using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task5108
{
    public class Rectangle
    {
        public string Id;
        public int Xn;
        public int Yn;
        public int W;
        public int H;
        public Rectangle(string Id, int Xn, int Yn, int W, int H)
        {
            this.Id=Id;
            this.Xn = Xn;
            this.Yn = Yn;
            this.H = H;
            this.W = W;
        }
        public override String ToString()
        {
            return String.Format("{{\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}}}", Xn, Yn, W, H);
        }
        public void shiftX(int dx)
        {
            Xn = Xn + dx;
        }
        public void shiftY(int dy)
        {
            Yn = Yn + dy;
        }
        public void stretchX(int dx)
        {
            W = W + dx;
        }
        public void stretchY(int dy)
        {
            H = H + dy;
        }
    }
}
