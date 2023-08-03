using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _051_산술_연산자_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 산술연산자
            Console.WriteLine("5+5는" + (5 + 5) + "입니다.");
            Console.WriteLine("5-5는" + (5 - 5) + "입니다.");
            Console.WriteLine("5x5는" + (5 * 5) + "입니다.");
            Console.WriteLine("5/5는" + (5 / 5) + "입니다.");
            Console.WriteLine("5/3의 나머지는" + (5 % 3) + "입니다.");

            // 대입연산자
            int a = 90;
            int b = 90;
            int c = 90;
            int d = 90;
            int e = 90;

            a += 10; //a = a+10;으로 기술해도 같음
            b -= 10; //b = b-10;으로 기술해도 같음
            c *= 10; //c = c*10;으로 기술해도 같음
            d /= 10; //d = d/10;으로 기술해도 같음
            e %= 10; //e = e%10;으로 기술해도 같음
            Console.WriteLine("90을 10을 더하면" + a + "입니다.");
            Console.WriteLine("90을 10을 빼면" + b + "입니다.");
            Console.WriteLine("90을 10을 곱하면" + c + "입니다.");
            Console.WriteLine("90을 10을 나누면" + d + "입니다.");
            Console.WriteLine("90을 10을 나눠서 남는건" + e + "입니다.");
        }
    }
}
