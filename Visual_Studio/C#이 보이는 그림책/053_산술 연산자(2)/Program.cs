using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053_산술_연산자_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //증가연산자, 감소연산자
            int a = 1;
            Console.WriteLine("시작은" + a + "입니다.");
            a++;
            Console.WriteLine("1 증가시켜" + a + "가 되었습니다");
            a--;
            Console.WriteLine("1 감소기켜" + a + "로 돌아왔습니다");

            int b = 1;
            int c = 1;
            Console.WriteLine("전치라면 b는" + ++b + "가 됩니다.");
            Console.WriteLine("후치라면 c는" + c++ + "가 됩니다.");
            Console.WriteLine("후치였던 c를 다시출력하면 값이 증가된 " + c + "가 나타납니다.");
        }
    }
}
