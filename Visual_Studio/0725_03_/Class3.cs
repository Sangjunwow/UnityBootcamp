using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0725_03_
{
    internal class Class3 //internal 하나만 쓰게 만든다, 그러나 유니티는 3개나 쓰기떄문에
    {
        //인수를 가진 메소드
        public void a(int x) // int x는 대응대상
        {
            Console.WriteLine("인수는" + x);
        }
        public void b()
        {
            a(5); //메소드를 호출한다 :메소드명 (인수)
        }
        //인수를 가지지 않는 메소드
        public void a()
        {
            Console.WriteLine("Hello");
        }
        public void b()
        {
            a(); //메소드명
        }
    }
    //반환 값의 이용
    class Cals
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public void print()
        {
            int c;//메소드 int에 대응
            c = add(8, 6);//메소드명, 인수, add에 대응ㅁ
        }
    }
}

