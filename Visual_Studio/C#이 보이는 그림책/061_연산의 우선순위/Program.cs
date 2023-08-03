using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _061_연산의_우선순위
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //연산의 우선순위
            Console.WriteLine("2x8-6/2=" + (2 * 8 - 6 / 2));
            Console.WriteLine("2x(8-6)/2=" + (2 * (8 - 6) / 2));
            Console.WriteLine("1-2+3=" + (1 - 2 + 3));
            Console.WriteLine("1-(2+3)=" + (1 - (2 + 3)));
        }
    }
}
