using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.task8258
{
    public class Comparator8258 : Comparer<int>
    {
        public override int Compare(int x, int y)
        {
            if (Math.Abs(x - 6) == Math.Abs(y - 6))
            {
                return 0;
            }
            if (Math.Abs(x - 6) < Math.Abs(y - 6))
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
