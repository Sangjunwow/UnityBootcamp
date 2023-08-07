using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71_if문_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            if (a % 2 == 0)
            {
                Console.WriteLine(a + "는 짝수입니다.");
            }
            else
            {
                Console.WriteLine(a + "는 홀수입니다.");
            }
            int s = 65;
            Console.WriteLine("당신의 점수는" + s + "점입니다.");
            if (s < 70)
            {
                // {}을 하나로 묶는것을 블록이라고 한다
                Console.WriteLine("평균까지 앞으로" + (70-s) + "점입니다.");
                Console.WriteLine("분발하세요!");
            }
            else
            {
                Console.WriteLine("잘 했습니다!");
            }
        }
    }
}
