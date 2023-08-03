using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_논리형
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //논리형 <bool>
            int a = 10, b = 20;
            bool c, d, e;

            c = a < b;
            d = a > b;
            e = a == b;

            Console.WriteLine("a=" + a + "b=" + b);
            Console.WriteLine("a<b는 " + c);
            Console.WriteLine("a>b는 " + d);
            Console.WriteLine("a==b는 " + e);
            Console.WriteLine("");
            
            //조건연산자 <?>
            string right = "정답", wrong = "오답";
            bool value;

            value = true;
            string answer = value ? right : wrong;
            Console.WriteLine(answer);

            value = false;
            answer = value ? right : wrong;
            Console.WriteLine(answer);
        }
    }
}
