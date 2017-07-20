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
    }
}
