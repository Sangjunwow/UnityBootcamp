using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0711_loop_1to10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int i = 0;
            for (i = 0; i <= 10; i = i + 1) // <= 높거나 같음 ++ 1씩 더함
            {
                total = total + i;//조건문이 거짓이 될때까지 반복한다. 계속 참일경우 무한으로 돌아감
            }
            Console.WriteLine(total);
        }
        static void Main2(string[] arg)
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
//등차수열같은 수학공식을 쓰는게 더 최적화에 가까움