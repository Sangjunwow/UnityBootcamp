using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0725_03_
{
    internal class Class2
    {
        static void Main()
        {//메소드 안에 선언한 변수를 지역 변수라고 합니다
            /*int n = 2; // n의 스코프
            int x = 3; // n과 x의 스코프
            if (n > 0) { 
            int y = 2;//n과 x와 y의 스코프
                Console.WriteLine(x+","+y);
            }
*/
            /*int y = 1;
            if(y > 1) {
                int y = 2; // y의 스코프내 선언이 중복 되었음으로 오류
                Console.WriteLine(x+","+y);
            }
*/
   //필드의 유효 범위는 필드를 정의한 블록 안과 해당 블록의 안쪽에 있는 블록으로 한정함
        }
    }
    class Scope
    {//필드와 지역 변수는 같은 이름으로 지정할 수 있습니다
        int zoom = 1; //필드명
        void print() {
            int zoom = 2; //지역변수명
            Console.WriteLine(zoom + "," + this.zoom); //zoom 은 지역변수의 2값을 this zoom은 필드에서의 값 1을 가져온다
        }
                
    }
}
