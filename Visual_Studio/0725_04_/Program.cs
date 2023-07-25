using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0725_04_
{
    class Calc
    {
        public int Add(int a, int b) //대소문자 구분
        {
            return a + b;
        }
    }
    class Calculation
    {
        static void Disp()
        {
            int c;
            Calc calc = new Calc();
            c = calc.Add(8, 9);
            Console.WriteLine("8+9=" + c);
        }
        static void Main(string[] args)
        {
            Disp();//????? 왜?
        }
    }
}

