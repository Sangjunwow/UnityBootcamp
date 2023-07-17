using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class Program
    {
        // int: 정수 자료형
        //정수 상수: -111,111, 0, -211213123134~1231231123
        // string: 문자를 저장
        //"문자열" "1"과 1은 다르다. 1은 문자열 상수
        //float: 실수 자료형
        //1.1f, 2.3f, 4.12312f
        //bool: ture, false를 저장
        static void Main(string[] args)
        {//ms식 allman스타일
            int number1 = 10; // int앞에 캐멀라이징 뿐만 아니라 숫자를 넣으면안된다. 언더바만 가능. 다른곳에서도 통용되는 변수작명법
            int damage = -20; //변수 작명법 트랜드. 작명할때 의미를 부여한다
            string message = "helloWorld";
            Console.WriteLine(message + "bye"); // +를 붙이면 걍 뒤에 붙여서 나온다. string 쪽에서도 +가 적용된다

            number1 = 100; //앞에건 상관없이 뒤에걸 날려버린다


            int number1 = 0;
            string message1 = ""; //그렇기에 작업할때 초기화를 이와같이 먼저한다

            //주석은 설명용으로 쓰지만 트랜드는 아예 변수작명법으로부터 정의를 해놓아서 길게쓰지 않는다. 좋은습관
            // int a = 1식으로 변수작명법에 a,b,c 치환해서 쓰는건 굉장히 올드한방식. 쓰지마
            //아예 마이크로소프트에서 c#코딩 규칙을 설명한다 ex) camel작명법, allman 스타일

            Console.WriteLine(number1 + damage);
            Console.WriteLine(number1 - damage);
            Console.WriteLine(number1 * damage);
            Console.WriteLine(number1 / damage); //연산자는 5가지
            Console.WriteLine(number1 % damage); //산수연산자?
        }
    }
}
