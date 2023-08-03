using System;
using System.Collections.Generic; //list를 사용하는데 필요
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041_컬렉션
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
          int형 수치를 저장할 경우, 이렇게 기술 
          List<int> color = new List<int>();
          a.Add(10)
*/
            List<string> color = new List<string>();
            color. Add("blue");
            color.Add("red");
            color.Add("wow");
            Console.WriteLine("color[0] = " + color[0]);
            Console.WriteLine("color[1] = " + color[1]);
            Console.WriteLine("color[2] = " + color[2]);

            /*
            List<int> a = new List<int>() { 10, 20, 30, }; 
            //초기값을 add 말고 간단히 지정할 수도 있다
            Console.WriteLine("a[0] = " + a[0]);
            Console.WriteLine("a[1] = " + a[1]);
            Console.WriteLine("a[2] = " + a[2]);
            */

            /*
            List<int> a = new List<int>() { 10, 20, 30, };
            a.RemoveAt(1); //요소 삭제, 이경우 원래 a[1]이였던 20이 사라지고 30이 1이된다
            Console.WriteLine("요소삭제 후엔 a[1] = " + a[1]);
*/*/


        }
    }
}
