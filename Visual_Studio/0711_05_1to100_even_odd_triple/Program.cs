using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0711_1to100_even_odd
{
    internal class Program
    {
        //int
        //float
        //string
        //bool

        //array
        //int[] new int[크기]
        //시작이 0부터 시작 크기 -1
        //for(초기치; 조건; 증가식)
        //{
        //
        //} 한줄로 줄이는건 이제 트랜드가 아님
        // if 
        // 절차지향 프로그래밍 - 빠르지만 문제점 같이작업하기힘듬
        // 객체지향 프로그래밍 - 엔진들은 싹다 객체지향 = object (목적형) 
        //simple is best 절차가 더 빠르다,허나 혼자 작업하기 못하기에 객체를 사용. cpu성능 항상으로 차이도 미미함. c#도 그래서 더 널널해진편
        //IL2CPP = c#코드를 c++로 전환하는 unity의 중간언어
        //code.org 
        static void Main(string[] args)
        {
            int sumOdd = 0;
            for (int i = 1; i <= 100; i = i + 2)
            {
                sumOdd = sumOdd + i;
            }
            Console.WriteLine(sumOdd);

            int sumEven = 0;
            for (int i = 2; i <= 100; i = i + 2)
            {
                sumEven = sumEven + i;
            }
            Console.WriteLine(sumEven);

            int three = 0;
            for (int i = 0; i <= 100; i += 3)
            {
                three = i;
            }
            Console.WriteLine(three);
        }
    }
}

/*int num1 = 0;
int num2 = 0;
for (int i = 0; i <= 5; i++)
{
   if (i % 2 == 0)
    {
        num1 += i;
    } 
   else { num2 += i;}
//}
//Console.WriteLine("짝수:" + num1 + ", "+"홀수:" + num2); */

