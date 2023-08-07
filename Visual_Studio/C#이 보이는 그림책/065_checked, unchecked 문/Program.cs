using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _065_checked__unchecked_문
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
