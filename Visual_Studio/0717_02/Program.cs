using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0717_02
{
    internal class Program
    {
        static void swap(ref int a, ref int b)  //ref를 써야 참조하여 아래값을 가져다 쓴다
        {
            int c = 0;
            c = b;
            b = a;
            a = c;

            /* Console.WriteLine(a);
             Console.WriteLine(b);*/
        }

        //sum, avg;

        static void Calculate(int a, int b, out int outSum, out float outAvg) //out은 값만 받아온다, 아예 outsum, outavg라고 한다
        {
            outSum = a + b;
            outAvg = (float)outSum / 2.0f;
        }


        //위와 아래는 별개로 계산하기에 위 작업후 아래로 갈때 전에했던 정보를 날린다
        //위의 a와 아래 a는 다르다. 다른함수의 적용을 하지않는다

        static void Main(string[] arg)
        {
            int a = 1;
            int b = 2;

            swap(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);

            int sum = 0;
            float avg = 0;
            Calculate(a, b, out sum, out avg);
        }

        /*static void Main(string[] args)
        {
            int a = 100;
            {
                int a = 10;
                Console.WriteLine(a)
            }
            Console.WriteLine(a) //둘다 10나온다.c#은 막지만 c언어는 컴파일가능
                        }
*/
    }
}
