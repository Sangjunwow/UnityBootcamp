using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0725_05_
{
    class Class1
    {
        double CalcCircle(int rad = 1, double pi = 3.14) //선택적 인수 기본값을 설정합니다
        {
            return rad * rad * pi;
        }
        void Output()
        {
            double area;
            area = CalcCircle(); //CalcCircle(1,3.14) 동일
            area = CalcCircle(10);//CalcCircle(10,3.14) 동일
            area = CalcCircle(20, 3,149999);//CalcCircle(20,3.149999) 동일
        }
        //선택적 인수를 이용할때 기본값을 모든 인수에 설정할 필요는 없습니다.
        double CalcCircle2(int rad, double pi = 3.14) //두 번째 인수에만 기본값을 설정
            //단 첫번째 인수에만 기본값을 설정할 수는 없습니다. 인수에 기본값을 설정할땐
            //맨 끝에서부터 차레로 설정해야 합니다.
            double CalcCircle(int rad = 1, double pi) //컴파일에러! 마지막 인수를 건너뛰고 기본값을 설정!
        //인수의 형을 바꾸거나 메소드 내의 처리로 바꾸고 싶을 때는 오버로드를 씁시다

            //망명된 인수
            //메소드 호출할땐 인수의 이름을 붙여서 호출할수 있습니다 
        void Output



        }
        }
    }
}
