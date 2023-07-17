using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _0713_01_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // p26 
            /*   Console.WriteLine("Hellow World!"); */



            // p28
            /* int a;
             int b;
             a = 2;
             b = 3;
             a = b;

             //int a; int b;
             //int a, b;

             //int a; a = 2;  
             //int a= 2;

             //int a; int b; 
             //a = 2; b = 3;
             //int a = 2, b = 3;

             Console.WriteLine(a+b);*/



            // p30
            //정수형
            //형에 따라 메모리를 사용하는 양이 다르다
            //s가 붙음으로 -값을 U가 붙음으로 -값이 사라진다
            /*     sbyte //-128~127
                 byte //0~255
                 short //-32768~32767
                 ushort // 0~65535
                 int // -2147483648~2147483647
                 unit // 0~4294967295
                 long // 2^64(비트수)
                 ulong //
     */
            /*//실수형
            float //소수 32
            double // 반올림의 오차를 없애고 소수점 이하의 값을 28자리까지 정확히*/

            /* //문자
             char a = 'A'; //16비트
             Console.WriteLine("A");
             Console.WriteLine("\u0041"); //\랑 역슬래쉬는 같은값이다
             char b = '가' //전각문자도 대입이 가능하며 ""가 아닌 ''이다
             string sweet = "candy"; //복수의 문자를 모은것을 문자열 ""이중인용 부호로 엮는다*/

            /*string candy = "캔디";
            int a = 3;

            string basket = candy + a + "개";
            Console.WriteLine(basket); //문자열은 "+" 연산자를 사용하려 연결이 가능하며 한쪽이 수치가 대입되어 있어도 문자열로 취급
*/


            //p34
            /*int[] a = new int[4]; //첨자는 0부터 시작하는 배열의 인덱스 번호이다. 0부터 시작함으로 요소수보다 1 작다
            int[] b = new int[] { 1, 2, 3, 4 };
            int[] c = { 1, 2, 3, 4 };*/

            /*int[] a = new int[4];
            int n = 1;
            a[0] = 1;
            a[1] = 2;
            a[2] = 3;
            a[3] = 4;
            Console.WriteLine(a[n]);*/



            //p36
            /*    int[] a = { 1, 2, 3, 4 };
                Console.WriteLine(a[0]);
                Console.WriteLine(a[1]);
                Console.WriteLine(a[2]);
                Console.WriteLine(a[3]);
    */
            /*int[]a=new int[3]; //1차원 배열
            int[,]a=new int[2,3]; //2차원 배열 y,x
            int[,,]a=new int[2,3,4];//3차원 배열 z,y,x
*/
            /*int[,] a =
            {
                {10,20},
                {30,40},  // {},의 조합에 주의
                {50,60}
                };
            a[1, 1] = 0; //a[1,1]에 0을 대입 
            //Console.WriteLine(a[1,0]); 
*/
            /*Console.WriteLine("a[0,0]은" + a[0,0] + '\t' + "a[0,1]은" + a[0,1]); //'\t'는 탭
            Console.WriteLine("a[1,0]은" + a[1,0] + '\t' + "a[1,1]은" + a[1,1]);
            Console.WriteLine("a[2,0]은" + a[2,0] + '\t' + "a[2,1]은" + a[2,1]);
*/


            //p38 재그 배열
            /*int[][] a = new int[3][]; //3은 최초 차원의 크기(요소 수)
            a[0] = new int[3] { 10, 20, 30 };
            a[1] = new int[2] { 40, 50 };
            a[2] = new int[1] { 60 };
*/
            /*int[][] a = new int[][]
            {
                new int[] { 10, 20, 30 },
                new int[] { 40, 50 },
                new int[] { 60 },
            }; //이런식으로 선언과 동시에 초기화 *초기화는 최초값을 할당하는 행위
*/
            /*            int[] a = new int[4];
                        int b = a.Length;
                        Console.WriteLine(b);

                        int[,] c = new int[3, 2];
                        int d = c.Length;
                        Console.WriteLine(d);

                        int[][] f = new int[][] {
                         new int[] { 10, 20, 30 },
                        new int[] { 40, 50 } };
                        int g = f.Length;
                        int h = f[0].Length; //[]안에 첨자
                        Console.WriteLine(g);
                        Console.WriteLine(h);
            */



            // p40 list 컬렉션

            /*List<int> color = new List<int>();
           a.Add(10)
*/
            /*List<string> color = new List<string>();
            color. Add("blue");
            color.Add("red");
            color.Add("wow");
            Console.WriteLine("color[0] = " + color[0]);
            Console.WriteLine("color[1] = " + color[1]);
            Console.WriteLine("color[2] = " + color[2]);
*/
            /*List<int> a = new List<int>() { 10, 20, 30, }; //초기값을 add 말고 간단히 지정
            Console.WriteLine("a[0] = " + a[0]);
            Console.WriteLine("a[1] = " + a[1]);
            Console.WriteLine("a[2] = " + a[2]);

            a.RemoveAt(1); //요소 삭제, 이경우 원래 a[1]이였던 20이 사라지고 30이 1이된다
            Console.WriteLine("요소삭제 후엔 a[1] = " + a[1]);
*/



            //p42 enum열거형
            //???왠진 모르겠다만 이넘은  main 밖에다 써야하는듯

            /*enum Animal { mouse, cat, bird, dog, koala, pig, lion};//마우스 부터0으로 정수값이 할당됨,  기본값은 int
            enum Animal2 { mouse, cat, bird, dog=100, koala, pig=200, lion}; // 등호를 통해 임의의 정수값을 줄수있다 이때 dog뒤의 koala는 101, pig뒤의 lion은 201이 된다 
            enum animal3 : byte{ mouse, cat, bird, dog = 100, koala, pig = 200, lion }; //:를 이용해 기본값이였던 int를 byte로 바꾸기

             Animal a;
             a = Animal.dog;
             Console.WriteLine(Animal.cat); //열거형명. 열거 정수
             Console.WriteLine((int)Animal.dog); //(정수형)을 앞에 붙여 형을 변환하면 정수값을 참조할수 있습니다?
             Console.WriteLine((int)Animal.lion);
             Console.WriteLine1(a); 
 */




        }
    }
}
