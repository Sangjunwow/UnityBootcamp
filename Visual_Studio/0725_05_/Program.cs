using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0725_05_
{
    /// <summary>
    /// 오버로드 한클래스안 같은 이름이지만 
    /// 인수의 값이나 형이 서로다른 메소드 여러개를 정의
    /// 반환값만 다른 메소드는 오류가 됩니다
    /// </summary>
    class Cat
    {
        string name;
        string place;
        int age;

        public void setData(string n, string p, int a)
        {
            name = n;
            place = p;
            age = a;
        }
        public void print()
        {
            Console.WriteLine(place + ":" + name + " " + age + "세");
        }
        public void print(string p, int a)
        {
            place = p;
            Console.WriteLine(place + ":고양이는" + a + "마리입니다");
        }
        public void print(string variety)
        {
            Console.WriteLine(place + ":" + name + " " + age + "세" + variety);
        }

    }
    //대응하는 메소드에 맞춰서 호출된다
    class Pet
    {
        static void Main()
        {
            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            Cat cat3 = new Cat();

            cat1.setData("로빈", "우리집", 10); 
            cat2.setData("꼬마", "옆집", 14);//프린트 값이 없어서 첫번째 메소드로 호출
            cat1.print("잡종");//variety 때문에 세번째 메소드로 호출??????
            cat2.print();
            cat3.print("뒷집",0);//두개의 variables를 가져서 두번째 메소드로 호출
        }
    }
 }

