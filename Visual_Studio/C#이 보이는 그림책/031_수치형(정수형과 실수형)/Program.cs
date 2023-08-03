using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_수치형_정수형과_실수형_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

/*
정수형
형에 따라 메모리를 사용하는 양이 다르다
s가 붙음으로 -값을 U가 붙음으로 -값이 사라진다
     sbyte  / (2^8) -128 ~ 127
     byte   / (2^8) 0 ~ 255
     short  / (2^16) -32768 ~ 32767
     ushort / (2^16) 0 ~ 65535
     int    / (2^32) -2147483648 ~ 2147483647
     unit   / (2^32) 0 ~ 4294967295
     long   / (2^64) -9223372036854775808 ~ 9223372036854775807 
     ulong  / (2^64) 0 ~ 18446744073709551615
*/

/*
실수형
float  /소수 2^32
double / 소수 2^64

decimal/ 소수 2^128
실수계산은 내부적으로 2진수로 수행,정밀도가 떨어져 오차가 발생한다 
반올림의 오차를 없애고 소수점 이하의 값을 28자리까지 정확히
*/
