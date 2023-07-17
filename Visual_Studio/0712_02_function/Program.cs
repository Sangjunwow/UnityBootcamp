using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0712_02_function
{
    internal class Program //그냥 없다고 생각하자. 지금상황에선 설명불가
    {
        //슬래쉬 세번 써서 나오는 설명문으로 함수설명문을 작성할수있다
        /// <summary>
        /// 이건 정수 숫자 두개 더한다
        /// </summary>
        /// <param name="a">첫번째숫자</param>
        /// <param name="b">두번째숫자</param>
        /// <returns>결과</returns>

        static int Add(int a, int b) //함수는 파스칼케이스
        { 
            return a + b; 
        }

        static int Minus(int a, int b) 
        {
            return a - b;
        }

        static int Mutiple(int a, int b) 
        {
            return a * b;
        }

        static int Divide(int a, int b) 
        {
            return a / b;
        }

        static int Modulate(int a, int b) 
        {
            return a % b;
        }

        static int void DoSomething()
        {
            void
        }
    
        static void Main(string[] args) 
        {
            
            Console.WriteLine(Add(2, 3));
            Console.WriteLine(Minus(2, 3));
            Console.WriteLine(Divide(2, 3));
            Console.WriteLine(Modulate(2, 3));
            Console.WriteLine(Mutiple(2, 3));

        }
    }
}

