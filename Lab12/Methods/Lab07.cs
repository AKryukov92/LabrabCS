using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Lab07
    {
        public static string task4265(string t)
        {
            string t1 = t.Substring(0, 1);
            if (t1 == "s")
            {
                return t.ToLower();
            }
            if (t1 == "U")
            {
                return t.ToUpper();
            }
            else
            {
                return t;
            }
        }
        public static bool task7491(string in7491)
        {
            string t = "abcdefwxyz";
            if (t.Contains(in7491))
            {
                 return true;
            }
            else
            {
                 return false;
            }
        }
    }
}
