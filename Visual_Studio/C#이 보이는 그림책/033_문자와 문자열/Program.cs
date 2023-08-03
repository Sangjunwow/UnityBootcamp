using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_문자와_문자열
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = 'A'; //16비트
            Console.WriteLine("A");
            Console.WriteLine("\u0041"); //\랑 역슬래쉬는 같은값이다
            char b = '가'; //전각문자도 대입이 가능하며 ""가 아닌 ''이다

            string sweet = " candy ";
            //복수의 문자를 모은것을 문자열 ""이중인용 부호로 엮는다



            string candy = " 캔디 ";
            int c = 3;

            string basket = candy + c + " 개 ";
            Console.WriteLine(basket);

        }
    }
}
