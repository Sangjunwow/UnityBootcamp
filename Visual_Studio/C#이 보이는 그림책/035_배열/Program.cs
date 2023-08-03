using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035_배열
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[4]; //첨자는 0부터 시작하는 배열의 인덱스 번호이다. 0부터 시작함으로 요소수보다 1 작다
            int[] b = new int[] { 1, 2, 3, 4 };
            int[] c = { 1, 2, 3, 4 };

            int[] d = new int[4];
            int n = 1;
            a[0] = 1;
            a[1] = 2;
            a[2] = 3;
            a[3] = 4;
            Console.WriteLine(d[n]);
            Console.WriteLine();

            int[] e = { 1, 2, 3, 4 };
            Console.WriteLine(e[0]);
            Console.WriteLine(e[1]);
            Console.WriteLine(e[2]);
            Console.WriteLine(e[3]);
        }
    }
}
