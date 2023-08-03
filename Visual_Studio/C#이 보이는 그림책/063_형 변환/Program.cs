using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _063_형_변환
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //형 변환
            Console.WriteLine("3/2=" + 3 / 2); //정수끼리 계산하면 답은 정수로만 나와서 나머지를 버리는 오답이 나온다
            Console.WriteLine("3.0/2.0=" + 3.0 / 2.0); //실수를 포함하고 있는 계산일 경우 정수는 자동적으로 실수로 변환된다
            Console.WriteLine("3.0/2=" + 3.0 / 2);
            Console.WriteLine("3/2.0=" + 3 / 2.0);

            short s = 536; //정수끼리 계산에서는 범위가 가장 큰 벙위의 형으로 변환
            byte b = 12;
            int a = s + b; //short형으로 변환된 548이 int형 변수 a에 대입됨
         
            // 정밀도나 범위다른 형끼리 대입 / 캐스트 연산자
            /* 
            int a = 8;
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
             sbyte m = n;//범위를 감당할 수 없는 형에 대입
            */
            Console.WriteLine(" 3/2=" + (float)3 / 2); // "형환" ()를 쳐서 변환가능 ;
            Console.WriteLine(" 3/2=" + 3 / (float)2); // float으로 형 변환
        }
    }
}
