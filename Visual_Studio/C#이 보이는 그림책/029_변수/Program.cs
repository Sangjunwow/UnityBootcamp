using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_변수
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a; 
            int b;
            a = 2; 
            b = 3;
            a = b;// 원래의 a값은 삭제된다

            Console.WriteLine(a);

            /*
            선언과 대입을 동시에 수행하는 작업을
            변수를 초기화한다고 한다
            ex) int a = 2, b = 3
            */
        }
    }
}
