using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0711_07_float
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //형 변환
            //casting
            //int <-> float


            int score = 100;
            float average = 0.3f;

            // 잘못된 문법시 c언어는 실행이 되지만 걍 꺼짐, c++부터는 문법을 따져서 실행막음
            // 그렇기에 둘중하나를 바꿔야한다

            int sum = score + (int)average; // 뒤에것을 int로 바꿔줌 


            float fsum = (float)score + average; //앞에것을 바꿔줌

            Console.WriteLine(sum);
            Console.WriteLine(fsum);
            //뭘바꿔주냐에 따라 결과값이 달라진다

            //int <-> string

            string numberString = "10"; // 이상한거 넣을 유저로부터 프로그램이 죽지않게 if문 삽입


            bool result = int.TryParse(numberString, out number); // 바꿀수있음 true 아님 false 해줌
            if (result)
            {
                Console.WriteLine(number + 20);
            }
            else
            {
                Console.WriteLine("에러입니다");
            }

            int number = int.Parse(numberString);

            Console.WriteLine(numberString + 20);

            //int를 string 으로
            int number = 0;

            number = int.Parse(numberString);
            Console.WriteLine(number.ToString() + 20.ToString());

            //float를 string 으로
            float number = 0;

            number = float.Parse(numberString);
            Console.WriteLine(number + 20.3f);

            //bool <-> int는 안됀다~~
            //bool <-> string
            bool check = true;
            Console.WriteLine(check.ToString + "is king");

            bool result = bool.Parse("true");

            //예시
            string userId = "";
            string password = "";

            if (userId=="test" && password== "1234") 
                //산술연산자
                //증감연산자 ++,--
                //논리연산자
                //비교연산자

                for(int i = 0; i < 100: ++i)
                for(int i = 0; i<100; i++) //둘중 위가 더 빠르나 컴터가 빨라져서 이젠 노상관

                //연산자끼리는 우선순위가 있으나 가로로 묶어라

                //&& and
                //|| or
                //! not
            {
                Console.WriteLine("맞습니다");
            }
            else
            {
                Console.WriteLine("응아니야")
            }

        }
    }
}
