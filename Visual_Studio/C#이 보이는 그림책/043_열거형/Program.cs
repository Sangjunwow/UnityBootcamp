using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043_열거형
{
    internal class Program
    {
        enum Animal { mouse, cat, bird, dog, koala, pig, lion };//마우스 부터0으로 정수값이 할당됨,  기본값은 int
        enum Animal2 { mouse, cat, bird, dog = 100, koala, pig = 200, lion }; // 등호를 통해 임의의 정수값을 줄수있다 이때 dog뒤의 koala는 101, pig뒤의 lion은 201이 된다 
        enum animal3 : byte { mouse, cat, bird, dog = 100, koala, pig = 200, lion }; //:를 이용해 기본값이였던 int를 byte로 바꾸기

        static void Main(string[] args)
        {
            Animal a;
            a = Animal.dog;
            Console.WriteLine(Animal.cat); //열거형명. 열거 정수
            Console.WriteLine((int)Animal.dog); //(정수형)을 앞에 붙여 형을 변환하면 정수값을 참조할수 있습니다?
            Console.WriteLine((int)Animal.lion);
            Console.WriteLine(a);
        }
    }
}
