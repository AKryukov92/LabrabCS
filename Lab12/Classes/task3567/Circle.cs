using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task3567
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
            return String.Format("<circle cx='{0}' cy='{1}' r='{2}'", cx, cy, r);
        }
        public void shiftX(int dx)
        {
            if (cx + dx < r)
            {
                Exception error = new Exception("Левая точка круга должна иметь неотрицательные координаты");
                throw error;
            }
            cx = cx + dx;
        }
        public void shiftY(int dy)
        {
            if (cy + dy < r)
            {
                Exception error = new Exception("Верхняя точка круга должна иметь неотрицательные координаты");
                throw error;
            }
            cy = cy + dy;
        }
        public void stretchX(int dw)
        {
            if (r+dw/2 <0)
            {
                Exception error = new Exception("Ширина должна быть положительной");
                throw error;
            }
            cx = cx + dw / 2;
            cy = cy + dw / 2;
            r = r + dw / 2;
        }
        public void stretchY(int dw)
        {
            if (r +dw/2 < 0)
            {
                Exception error = new Exception("Высота должна быть положительной");
                throw error;
            }
            cx = cx + dw / 2;
            cy = cy + dw / 2;
            r = r + dw / 2;
        }
    }
}
