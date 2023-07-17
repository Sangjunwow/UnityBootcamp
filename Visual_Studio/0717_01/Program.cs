using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void A()
        {
            Console.WriteLine("A");
        }

        //functional overloading
        //naming management
        static int Add(int x, int y)
        {
            A();
            return x + y;
        }

        static float Add(float x, float y)
        {
            return x + y;
                }

        static string Add(string x, string y) //반환값과 인자만 다르다
        {
            return x + y;
        }

/*        static T Add<T>(T x, T y) //제네틱메소드
        {
            return (T)(x) + (T)(y);
     */   }
        static void Main(string[] args)
        {
            Add(1,2);
           Add(1.1f,2.2f); //int함수만 있었음 충돌난다
            Add("Hello", "World"); //컴퓨터는 같은 add함수에 임의로 번호를 맥이고 처리함
        }
    }
}
