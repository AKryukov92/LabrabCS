using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Lab06
    {
        public static int task5969(int A, int B)
        {
            int sum = 0;
            if (A < B)
            {
                while (A <= B)
                {
                    if (A % 7 == 0)
                    {
                        sum = sum + A;
                    }
                    A++;
                }
                return sum;
            }
            else
            {
                while (B <= A)
                {
                    if (B % 7 == 0)
                    {
                        sum = sum + B;
                    }
                    B++;
                }
                return sum;
            }
            return 0;
        }
        public static StringBuilder task8495(StringBuilder sb8495)
        {
        int i = 0;
        while (i<13) {
            sb8495.Append("!");
            i=i+1;
            }
        return sb8495;
        }
        public static StringBuilder task1315(StringBuilder sb1315)
        {
            int a = 17;
            int b = 47;
            while (a <= b)
            {
                sb1315.Append(a + " ");
                a = a + 1;
            }
            return sb1315;
        }
        public static StringBuilder task3762(StringBuilder sb3762)
        {
            int f = 1;//фунты
            double g; //граммы
            while (f <= 20)
            {
                g = f * 453;//граммы
                if (f <= 9)
                {
                    sb3762.Append (f + "   " + g + "\n");
                }
                else
                {
                    sb3762.Append (f + "  " + g + "\n");
                }
                f = f + 1;
            }
            return sb3762;
        }
        public static StringBuilder task3550(StringBuilder sb3550)
        {
            int a = 1;
            int b;
            while (a < 10)
            {
                b = a * 7;
                sb3550.Append(a +"*7=" + b + "\n");
                a = a + 1;
            }
            return sb3550;
        }
        public static StringBuilder task6572(StringBuilder sb6572, int A, int B)
        {
            int i = 1;
            int count = 0;// количество чисел 
            if (A < B)
            {
                if (A % 2 == 0)
                {
                    A = A + 1;
                    sb6572.Append(A + "\n");
                    while (A < B)
                    {
                        A = A + 2;
                        if (A > B)
                        sb6572.Append("\n");
                        count = count + 1;
                        i = 1;
                        while (i <= count)
                        {
                            sb6572.Append(".");
                            i++;
                        }
                        sb6572.Append(A + "\n");
                    }
                }
                else
                {
                    sb6572.Append(A + "\n");
                    while (A < B)
                    {
                        A = A + 2;
                        if (A >= B)
                        sb6572.Append("\n");
                        count = count + 1;
                        i = 1;
                        while (i <= count)
                        {
                            sb6572.Append(".");
                            i++;
                        }
                        sb6572.Append(A + "\n");
                    }
                }
            }
            else
            {
                if (B % 2 == 0)
                {
                    B = B + 1;
                    sb6572.Append(B + "\n");
                    while (B < A)
                    {
                        B = B + 2;
                        if (B > A)
                        sb6572.Append("\n");
                        count = count + 1;
                        i = 1;
                        while (i <= count)
                        {
                            sb6572.Append(".");
                            i++;
                        }
                        sb6572.Append(B + "\n");
                    }
                }
                else
                {
                    sb6572.Append(B + "\n");
                    while (B < A)
                    {
                        B = B + 2;
                        if (B > A)
                        sb6572.Append("\n");
                        count = count + 1;
                        i = 1;
                        while (i <= count)
                        {
                            sb6572.Append(".");
                            i++;
                        }
                        sb6572.Append(B + "\n");
                    }
                }
            }
            return sb6572;
        }
        public static StringBuilder task2084(StringBuilder sb2084, int A, int B)
        {
            int C = A;
            if (A < B)
            {
                if (A % 2 == 0)
                {
                    A = A + 1;
                        while (A <= B)
                        {
                            if (A==C+1)
                            {
                                sb2084.Append(A);
                            }
                            else
                            {
                                sb2084.Append(", " + A);
                            }
                            A = A + 2;
                        }
                    }
                else
                {
                    while (A <= B)
                    {
                        if (A == C)
                        {
                            sb2084.Append(A);
                        }
                        else
                        {
                            sb2084.Append(", " + A);
                        }
                        A = A + 2;
                    }
                }
            }
            else
            {
                if (A % 2 == 0)
                {
                    A = A - 1;
                    while (B <= A)
                    {
                        if (A == C-1)
                        {
                            sb2084.Append(A);
                        }
                        else
                        {
                            sb2084.Append(", " + A);
                        }
                        A = A - 2;
                    }
                }
                else
                {
                    while (B <= A)
                    {
                        if (A == C)
                        {
                            sb2084.Append(A);
                        }
                        else
                        {
                            sb2084.Append(", " + A);
                        }
                        A = A - 2;
                    }
                }
            }
            return sb2084;
        }
        public static StringBuilder task5411(StringBuilder sb5411, int P, int Q)
        {
            int C = (P + Q) / 2;//середина строчки
            if (P < Q)
            {
                while (P < C)
                {
                    sb5411.Append(P + "<");
                    P = P + 1;
                }
                while (P < Q)
                {
                    sb5411.Append(P + ">");
                    P = P + 1;
                }
                if (P == Q)
                {
                    sb5411.Append(P);
                }
            }
            else
            {
                while (Q < C)
                {
                    sb5411.Append(Q + "<");
                    Q = Q + 1;
                }
                while (Q < P)
                {
                    sb5411.Append(Q + ">");
                    Q = Q + 1;
                }
                if (Q == P)
                {
                    sb5411.Append(Q);
                }
            }
            return sb5411;
        }
        public static StringBuilder task7585(StringBuilder sb7585, int in7585)
        {
            int i = 10;
            while (i <= 20)
            {
                if (i == in7585)
                {
                    sb7585.Append(i + "+"+"\n");
                }
                else
                {
                    sb7585.Append(i+"\n");
                }
                i = i + 1;
            }
            return sb7585;
        }
        public static StringBuilder task8770(StringBuilder sb8770, int in8770)
        {
            int i = 30;
            while (i <= 40)
            {
                if (i == in8770)
                {
                    sb8770.Append(i + "+" +"\n");
                }
                else
                {
                    sb8770.Append(i + "-" + "\n");
                }
                i = i + 1;
            }
            return sb8770;
        }
        public static double task2802(int n)
        {
            //int i=1;
            double j = n;
            double sum=0;
            if (n <=0) {
                Exception error=new Exception("Значение N должно быть положительным");
                throw error;
            }
            while(j>0) {
                sum = sum + 1 / j;
                j=j-1;
            }
            return sum;
        }
        public static int task9180(int in9180)
        {
            int sum = 0;
            if (in9180 > 500 || in9180 < -100)
            {
                Exception error=new Exception("Значение А должно быть диапазоне от -100 до 500");
                throw error;
            }
            while (in9180 <= 500)
            {
                sum = sum + in9180;
                in9180++;
            }
            return sum;
        }
        public static int task1544(int in1544)
        {
            int sum = 0;
            if (in1544 > 10000 || in1544 < -10)
            {
                Exception error = new Exception("Значение b должно быть в интервале [-10,10000]");
                throw error;
            }
            while (in1544 >= -10)
            {
                sum = sum + in1544;
                in1544--;
            }
            return sum;
        }
        public static bool task5170(int in5170)
        {
            int i = 2;
            bool isPrime=false;//true или false
            if (in5170 <= 0)
            {
                Exception error = new Exception("Значение Y должно быть положительным");
                throw error;
            }
            while (i <= in5170 / 2)
            {
                if (in5170 % i == 0)
                {
                    isPrime=true;
                }
                i++;
            }
            if (isPrime)
            {
               return true;
            }
            else
            {
                return false;
            }
        }
        public static StringBuilder task5238(StringBuilder sb, int in5238w, int in5238h)
        {
            int i = 0;
            int j = 0;
            if (in5238w < 0)
            {
                Exception error = new Exception("Значение W должно быть неотрицательно");
                throw error;
            }
            if (in5238h < 0)
            {
                Exception error = new Exception("Значение H должно быть неотрицательно");
                throw error;
            }
            if (in5238h==0)
            {
                return sb.Append("");
            }
            if (in5238w == 0)
            {
                return sb.Append("");
            }
            while (j < in5238h)
            {
                i = 0;
                while (i < in5238w - j)
                {
                    sb.Append("+");
                    i++;
                }
                i = 0;
                while (i < j)
                {
                    sb.Append("#");
                    i++;
                }
                j++;
                sb.Append("\n");
            }
            return sb;
        }
        public static StringBuilder task5448(StringBuilder sb, string in5448s, int in5448h)
        {
            int j = 0;
            int i = 0;
            if (in5448h < 0)
            {
                Exception error = new Exception("Значение H должно быть неотрицательно");
                throw error;
            }
            while (i < in5448h)
            {
                while (j <= i)
                {
                    sb.Append(in5448s);
                    j++;
                }
                j = 0;
                sb.Append("\n");
                i++;
            }
            return sb;
        }
        public static StringBuilder task7517(StringBuilder sb, int in7517w, int in7517h)
        {
            int i = 0;
            int j = 0;
            if (in7517w < 0)
            {
                Exception error=new Exception("Значение W должно быть неотрицательно");
                throw error;
            }
            if (in7517h < 0)
            {
                Exception error=new Exception("Значение H должно быть неотрицательно");
                throw error;
            }
            if (in7517h==0)
            {
                return sb.Append("");
            }
            if (in7517w == 0)
            {
                return sb.Append("");
            }
            sb.Append(" ");
            while (j < in7517w)
            {
                sb.Append(j);
                j++;
            }
            sb.Append("\n");
            while (i < in7517h)
            {
                sb.Append(i);
                j = 0;
                while (j < in7517w)
                {
                    sb.Append(" ");
                    j++;
                }
                sb.Append("|");
                sb.Append("\n");
                i++;
            }
            j = 0;
            sb.Append(" ");
            while (j < in7517w)
            {
                sb.Append("-");
                j++;
            }
            return sb;
        }
        public static StringBuilder task4075(StringBuilder sb, int in4075)
        {
            int j=1;
            if (in4075 < 0)
            {
                Exception error=new Exception("Значение W должно быть неотрицательно");
                throw error;
            }
            if (in4075 == 0)
            {
                Exception error = new Exception("");
                throw error;
            }
            sb.Append("+");
            while (j <= in4075 - 2)
            {
                sb.Append("-");
                j++;
            }
            sb.Append("+");
            sb.Append("\n");
            sb.Append("|");
            j = 1;
            while (j <= in4075 - 2)
            {
                sb.Append(".");
                j++;
            }
            sb.Append("|");
            sb.Append("\n");
            sb.Append("+");
            j = 1;
            while (j <= in4075 - 2)
            {
                sb.Append("-");
                j++;
            }
            sb.Append("+");
            sb.Append("\n");
            return sb;
        }
        public static StringBuilder task2592(StringBuilder sb, string in2592s, int in2592w, int in2592h)
        {
            int i = 1;
            int j = 1;
            if (in2592w < 0)
            {
                Exception error=new Exception("Значение W должно быть неотрицательно");
                throw error;
            }
            if (in2592h < 0)
            {
                Exception error = new Exception("Значение H должно быть неотрицательно");
                throw error;
            }
            if (in2592w==0)
            {
                return sb.Append("");
            }
            while (i<=in2592h)
            {
                j = 1;
                while (j <=in2592w)
                {
                    sb.Append(in2592s);
                    j++;
                }
                sb.Append("\n");
                i++;
            }
            return sb;
        }
        public static StringBuilder task5568(StringBuilder sb, int in5568)
        {
            int i = 1;
            int j = 0;
            if (in5568 < 0 || in5568 > 20)
            {
                Exception error=new Exception("Значение W должно быть в интервале [0, 20]");
                throw error;
            }
            while (j <= 9)
            {
                while (i <= in5568)
                {
                    sb.Append(j);
                    i++;
                }
                i = 1;
                j++;
                sb.Append("\n");
            }
            return sb;
        }
        public static StringBuilder task8395(StringBuilder sb, int in8395)
        {
            int i = 1;
            if (in8395 < 0 || in8395 > 20)
            {
                Exception error=new Exception("Значение W должно быть в интервале [0, 20]");
                throw error;
            } 
            while (i <= in8395)
            {
                sb.Append("a");
                i++;
            }
            sb.Append("\n");
            i = 1;
            while (i <= in8395)
            {
                sb.Append("b");
                i++;
            }
            sb.Append("\n");
            i = 1;
            while (i <= in8395)
            {
                sb.Append("c");
                i++;
            }
            sb.Append("\n");
            i = 1;
            while (i <= in8395)
            {
                sb.Append("d");
                i++;
            }
            sb.Append("\n");
            i = 1;
            while (i <= in8395)
            {
                sb.Append("e");
                i++;
            }
            sb.Append("\n");
            i = 1;
            while (i <= in8395)
            {
                sb.Append("f");
                i++;
            }
            sb.Append("\n");
            i = 1;
            while (i <= in8395)
            {
                sb.Append("g");
                i++;
            }
            sb.Append("\n");
            i = 1;
            while (i <= in8395)
            {
                sb.Append("h");
                i++;
            }
            sb.Append("\n");
            return sb;
        }
        public static StringBuilder task4236(StringBuilder sb, int in4236)
        {
            int i = 1;
            if (in4236 > 15 || in4236 < 0)
            {
                Exception error=new Exception("Значение Y должно быть в интервале [0, 15]");
                throw error;
            }
            while (i <= 15)
            {
                if (i <= in4236)
                {
                    sb.Append("#");
                }
                else
                {
                    sb.Append(".");
                }
                i++;
            }
            return sb;
        }
        public static StringBuilder task3983(StringBuilder sb, int in3983)
        {
            int i = 0;
            if (in3983 < 0)
            {
                Exception error=new Exception("Значение N должно быть неотрицательным");
                throw error;
            }
            while (i < in3983)
            {
                sb.Append("#");
                i++;
                if (i % 20 == 0)
                {
                    sb.Append("\n");
                }
            }
            return sb;
        }
        public static StringBuilder task1483(StringBuilder sb, int in1483)
        {
            int i = 0;
            if (in1483 < 0)
            {
                Exception error=new Exception("Значение N должно быть неотрицательным");
                throw error;
            }
            while (i < in1483)
            {
                sb.Append("!");
                i++;
                if (i % 5 == 0)
                {
                    sb.Append(" ");
                }
            }
            return sb;
        }
        public static StringBuilder task2594(StringBuilder sb, int in2594a, string in2594b)
        {
            int C = 0;
            if (in2594a < 0)
            {
                Exception error=new Exception("Значение А должно быть неотрицательным");
                throw error;
            }
            sb.Append("\"");
            while (C < in2594a)
            {
                sb.Append(in2594b);
                C = C + 1;
            }
            sb.Append("\"");
            return sb;
        }
        public static StringBuilder task2565(StringBuilder sb, int in2565a, int in2565b)
        {
            if (in2565a > in2565b)
            {
                Exception error=new Exception("Значение А должно быть не больше значения B");
                throw error;
            }
            while (in2565a <= in2565b)
            {
                sb.Append(in2565b + " ");
                in2565b = in2565b  - 1;
            }
            return sb;
        }
        public static StringBuilder task6066(StringBuilder sb, int in6066a, int in6066b)
        {
            if (in6066a > in6066b)
            {
                Exception error=new Exception("Значение А должно быть не больше значения B");
                throw error;
            }
            while (in6066a <= in6066b)
            {
                sb.Append(in6066a + "\n");
                in6066a++;
            }
            return sb;
        }
        public static StringBuilder task1862(StringBuilder sb, string in1862s1, string in1862s2, int in1862w, int in1862h)
        {
            int i = 0;
            int j = 0;
            if (in1862w < 0)
            {
                Exception error=new Exception("Значение W должно быть неотрицательно");
                throw error;
            }
            if (in1862h < 0)
            {
                Exception error=new Exception("Значение H должно быть неотрицательно");
                throw error;
            }
            if (in1862h==0)
            {
                return sb.Append("");
            }
            if (in1862w == 0)
            {
                return sb.Append("");
            }
            while (i < in1862h)
            {
                while (j < in1862w)
                {
                    if (j % 2 == 0)
                    {
                        sb.Append(in1862s1);
                    }
                    else
                    {
                        sb.Append(in1862s2);
                    }
                    j++;
                }
                j = 0;
                i++;
                sb.Append("\n");
            }
            return sb;
        }
        public static StringBuilder task5171(StringBuilder sb, string in5171s1, string in5171s2, int in5171w, int in5171h)
        {
            int i = 0;
            int j = 0;
            if (in5171w < 0)
            {
                Exception error=new Exception("Значение W должно быть неотрицательно");
                throw error;
            }
            if (in5171h < 0)
            {
                Exception error = new Exception("Значение H должно быть неотрицательно");
                throw error;
            }
            if (in5171h==0)
            {
                return sb.Append("");
            }
            if (in5171w == 0)
            {
                return sb.Append("");
            }
            while (i < in5171h)
            {
                j = 0;
                if (i % 2 == 0)
                {
                    while (j < in5171w)
                    {
                        sb.Append(in5171s1);
                        j++;
                    }
                }
                else
                {
                    while (j < in5171w)
                    {
                        sb.Append(in5171s2);
                        j++;
                    }
                }
                sb.Append("\n");
                i++;
            }
            return sb;
        }
        public static IList<double> task2321(double A, double B)
        {
            IList<double> list = new List<double>();
            if (A < B)
            {
                while (A <= B)
                {
                    list.Add(A);
                    A = A + 1;
                }
            }
            else
            {
                while (A >= B)
                {
                    list.Add(B);
                    B = B + 1;
                }
            }
            return list;
        }
        public static IList<double> task5053(double A, double B)
        {
            IList<double> list = new List<double>();
            if (A < B)
            {
                while (A <= B)
                {
                    list.Add(A);
                    A = A + 1;
                }
            }
            else
            {
                while (A >= B)
                {
                    list.Add(A);
                    A = A - 1;
                }
            }
            return list;
        }
        public static IList<int> task8418(int in8418i)
        {
            IList<int> list = new List<int>();
            int i=1;
            if (in8418i <= 0)
            {
                Exception error=new Exception("Значение X должно быть положительным");
                throw error;
            }
            while (i <= in8418i)
            {
                if (in8418i % i == 0)
                {
                    list.Add(i);
                }
                i++;
            }
            return list;
        }
    }
}

