using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1to10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1부터 10까지
            //int total = 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10;
            //Console.WriteLine(total);

            //10부터 1까지 루프써서
            //for ( int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //숫자 두개를 입력해 사칙연산
            int number1 = 0; //한줄에 쓸수있으나 이제 트랜드가 아님
            int number2 = 0; //이름은 용도에 맞게
            string readNumber1 = "";
            string readNumber2 = "";

            //input
            readNumber1 = Console.ReadLine();
            readNumber2 = Console.ReadLine();

            //process, update
            number1 =int.Parse(readNumber1);
            number2 =int.Parse(readNumber2);

            //print, render
            Console.WriteLine( number1+ number2);
            Console.WriteLine(number1 - number2);
            Console.WriteLine(number1 / number2);
            Console.WriteLine(number1 * number2);

            Console.WriteLine(number1 % number2);

            //int number1 = int.Parse(Console.ReadLine()); //한번에 쓰면 나중에 보수하기 힘듬
            //int number2 = int.Parse(Console.ReadLine()); //유저의 전제는 하지말라는거 한다
            //Console.WriteLine(number1 + number2);
            //Console.WriteLine(number1 - number2);
            //Console.WriteLine(number1 * number2);
            //Console.WriteLine(number1 / number2);

            //gameloop
            while (true) //트루에 파일을 다 읽으면등 조건
            {
                //input
                readNumber1 = Console.ReadLine();
                readNumber2 = Console.ReadLine();

                //process, update
                number1 = int.Parse(readNumber1);
                number2 = int.Parse(readNumber2);

                //print, render
                Console.WriteLine(number1 + number2);
                Console.WriteLine(number1 - number2);
                Console.WriteLine(number1 / number2);
                Console.WriteLine(number1 * number2);

                Console.WriteLine(number1 % number2);
            }
        }
    }
}
