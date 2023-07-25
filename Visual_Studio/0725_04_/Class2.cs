using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0725_04_
{
    //참조전달
    class Calc3
    {
        static void add10(ref int a) //ref를 붙입니다
        {
            a = a + 10;
        }
        public void print()
        {
            int x = 100;
            add10(ref x);
        }
    }
}
