using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*// pg.50 산술연산자
            Console.WriteLine("5+5는" + (5+5) + "입니다.");
            Console.WriteLine("5-5는" + (5-5) + "입니다.");
            Console.WriteLine("5x5는" + (5*5) + "입니다.");
            Console.WriteLine("5/5는" + (5/5) + "입니다.");
            Console.WriteLine("5/3의 나머지는" + (5%3) + "입니다.");
*/
            /* // pg. 51 대입연산자
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
 */
            /*//pg.52 증가연산자, 감소연산자
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
*/
            /*//pg.54 비교 연산자
            int a = 10, b = 20;
            Console.WriteLine("a = " + a + "b = " + b);
            Console.WriteLine("a<b 는 " + (a < b));
            Console.WriteLine("a>b 는 " + (a > b));
            Console.WriteLine("a == b 는 " + (a == b));
            Console.WriteLine("a = b 는" + (a = b));
*/
            /*//pg.56 논리형 <bool>
            int a =10, b =20;
            bool c, d, e;

            c = a < b;
            d = a > b;
            e = a == b;

            Console.WriteLine("a="+a+"b="+b);
            Console.WriteLine("a<b는 "+c);
            Console.WriteLine("a>b는 "+d);
            Console.WriteLine("a==b는 "+e);
*/
            /*//pg.57 조건연산자 <?>
            string right = "정답", wrong = "오답";
            bool value;

            value = true;
            string answer = value ? right : wrong;
            Console.WriteLine(answer);

            value = false;
            answer = value ? right : wrong;
            Console.WriteLine(answer);
*/
            /*//pg.58 논리 연산자
            int a = 3, b = 4;
            bool x, y;

            x = (a < 0);
            y = (b > 0);
            Console.WriteLine((a == 3) && (b == 3));
            Console.WriteLine(x || y);
*/
            /*//pg.60 연산의 우선순위
            Console.WriteLine("2x8-6/2=" + (2*8-6/2));
            Console.WriteLine("2x(8-6)/2=" + (2*(8-6)/2));
            Console.WriteLine("1-2+3=" + (1-2+3));
            Console.WriteLine("1-(2+3)=" + (1-(2+3)));
*/
            /*//pg.62 형 변환
            Console.WriteLine("3/2=" + 3/2); //정수끼리 계산하면 답은 정수로만 나와서 나머지를 버리는 오답이 나온다
            Console.WriteLine("3.0/2.0=" + 3.0/2.0); //실수를 포함하고 있는 계산일 경우 정수는 자동적으로 실수로 변환된다
            Console.WriteLine("3.0/2=" + 3.0/2);
            Console.WriteLine("3/2.0=" + 3 / 2.0);

            short s = 536; //정수끼리 계산에서는 범위가 가장 큰 벙위의 형으로 변환
            byte b = 12;
            int a = s + b; //short형으로 변환된 548이 int형 변수 a에 대입됨
*/
            /*//pg.63 정밀도나 범위다른 형끼리 대입 / 캐스트 연산자
            *//* int a = 8;
             float b = a; //정수형을 실수형에 대입
             double c = 2.8;
             long d = c; //실수형을 정수형,decimal형에 대입 (불가능)
             decimal e = 29;
             float f = e;//decimal형을 실수에 대입 (불가능)
             byte g = 10;
             int h = g; //범위가 더 큰 형에 대입
             long i = 35;
             short j = i;//범위가 더 작은 형에 대입 (불가능)
             int k = 41;
             char l = k;//수치형을 문자형에 대입 (불가능)
             byte n = 74;
             sbyte m = n;//범위를 감당할 수 없는 형에 대입*//*
            Console.WriteLine(" 3/2=" + (float)3 / 2); // "형환" ()를 쳐서 변환가능 ;
            Console.WriteLine(" 3/2=" + 3 / (float)2); // float으로 형 변환
*/
           /* //pg.64 checked, unchecked 문
            int a, b;
            try
            {
                checked//기본값에는 unchecked상태로 설정됨
                {
                    a = int.MaxValue; //int.MaxValue는 int의 최댓값
                    b = a + 1; // 1을 더해 오버플로 발생
                    Console.WriteLine(b);
                }
            }
            catch (OverflowException oe)//checked를 지정한 경우 오버플로 한 경우에 수행하는 예외처리도 작성해야함. unchecked는 해당사항없음
            {
                Console.WriteLine(oe.Message);
            }
*/
           //pg.65 도전! 
           //b10 c12 d12 e10
           //b가 a랑 같거나 높을때/a가 b랑 같지 아니할때/b가 a랑 같을때?/a를 b로 나눌때?/ ab가 같고 c가 b랑 같거나 높을떄/a가b랑 다르거나 c가 b보다 높을때/몰라
           //bool a; int a = (a !=100 || a != 200) !((a==100)||(a==200))  !(a==100)&&!(a==200)
           //10 /1 /-7 /-14
           //c
        }
    }
}
