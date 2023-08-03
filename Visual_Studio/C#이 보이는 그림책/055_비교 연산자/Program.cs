using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_비교_연산자
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //비교 연산자
            int a = 10, b = 20;
            Console.WriteLine("a = " + a + " b = " + b);
            Console.WriteLine("a<b 는 " + (a < b));
            Console.WriteLine("a>b 는 " + (a > b));
            Console.WriteLine("a == b 는 " + (a == b));
            Console.WriteLine("a = b 는" + (a = b));
        }
    }
}
