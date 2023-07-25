using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0725_04_
{
    class Calc2
    {
        public void div(int a, int b, out int q, out int r) { //인수 리스트 안에서 변수선언가능
            q = a / b;
            r = a % b;
        }
        public void print()
        {
            int x, y;
            div(10, 3, out x, out y); //호출하는쪽도 out을 붙입니다 div()의 계산결과가 들어갑니다
        }
    }
}
