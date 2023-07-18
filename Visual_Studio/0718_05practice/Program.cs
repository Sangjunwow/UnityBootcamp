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
            //pg.58 논리 연산자

            int a = 3, b = 4;
            bool x, y;

            x = (a < 0);
            y = (b > 0);
            Console.WriteLine((a == 3) && (b == 3));
            Console.WriteLine(x || y);
        }
    }
}
