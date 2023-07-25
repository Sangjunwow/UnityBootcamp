using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0725_03_
{//메소드
    class A
    {
        public int add(int a, int b) // public <반환 값의 형> <메소드명: 동작에 맞는 이름을 생각해 붙이기> (형과 변수명, 형과 변수명)
        {
            int x;
            x = a + b; //필요한 처리 작성
            return x;//return문 ('리턴'이라고 읽음) 메소드를 종료하고 반환 값을 반환하는 역할
        }
    }
    class B
    {
        void disp(int a)//disp 인수의 정수값을 표시하는 메소드 
                        //void "빈" 의미이며 반환값이 없음을 나타낸다
        {
            Console.WriteLine("인수의 값은" + a);
            return; //반환값이 없는 셩우 생략할수 있다
        }
        double half ()
        {
            b = a / 2.0;
            return b;
        }
        void print()
        {
            Console.WriteLine("hello");
        }
    }
}

