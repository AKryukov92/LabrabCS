using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task6981_1
{
    public class Rectangle : Shape
    {
        public string Id;
        public int Xn;
        public int Yn;
        public int W;
        public int H;
        public Rectangle(string Id, int Xn, int Yn, int W, int H)
        {
            this.Id = Id;
            this.Xn = Xn;
            this.Yn = Yn;
            this.H = H;
            this.W = W;
        }
        public override String ToString()
        {
            return String.Format("{{\"x\":{0}, \"y\":{1}, \"w\":{2}, \"h\":{3}}}", Xn, Yn, W, H);
        }
        public override void shiftX(int dx)
        {
            if (Xn + dx < 0)
            {
                Exception error = new Exception("Координата X должна быть неотрицательной");
                throw error;
            }
            Xn = Xn + dx;
        }
        public override void shiftY(int dy)
        {
            if (Yn + dy < 0)
            {
                Exception error = new Exception("Координата Y должна быть неотрицательной");
                throw error;
            }
            Yn = Yn + dy;
        }
        public override void stretchX(int dw)
        {
            if (W + dw <= 0)
            {
                Exception error = new Exception("Ширина должна быть положительной");
                throw error;
            }
            W = W + dw;
        }
        public override void stretchY(int dh)
        {
            if (H + dh <= 0)
            {
                Exception error = new Exception("Высота должна быть положительной");
                throw error;
            }
            H = H + dh;
        }
    }
}
