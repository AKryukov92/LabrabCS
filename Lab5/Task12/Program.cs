using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            if (t=="a")
            {
                Console.WriteLine("a+\nb\nc\nd\ne\nf\ng\nh" );
                return;
            }
            if (t == "b")
            {
                Console.WriteLine("a\nb+\nc\nd\ne\nf\ng\nh");
                return;
            }
            if (t == "c")
            {
                Console.WriteLine("a\nb\nc+\nd\ne\nf\ng\nh");
                return;
            }
            if (t == "d")
            {
                Console.WriteLine("a\nb\nc\nd+\ne\nf\ng\nh");
                return;
            }
            if (t == "e")
            {
                Console.WriteLine("a\nb\nc\nd\ne+\nf\ng\nh");
                return;
            }
            if (t == "f")
            {
                Console.WriteLine("a\nb\nc\nd\ne\nf+\ng\nh");
                return;
            }
            if (t == "g")
            {
                Console.WriteLine("a\nb\nc\nd\ne\nf\ng+\nh");
                return;
            }
            if (t == "h")
            {
                Console.WriteLine("a\nb\nc\nd\ne\nf\ng\nh+");
                return;
            }
            if (t == "i"||t=="j"||t=="k"||t == "l"||t=="m"||t=="n"||t =="o"||t=="p"||t=="q"||t =="r"||t=="s"||t=="t"||t=="u"
                ||t=="v"||t=="w"||t =="x"||t=="y"||t=="z")
            {
                Console.WriteLine("a\nb\nc\nd\ne\nf\ng\nh");
                return;
            }
        }
    }
}
