using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0725_03_
{
    //다른 객체의 메소드
    class Calc //클래스
    {
        public int add(int a, int b){
            return a + b;
        }
    }
    class Math
    {
        static void Main()
        {
            Calc calc = new Calc(); //인스턴트
            Console.WriteLine(" 3 + 9 =" + calc.add(3,9));
        }
    }
}
