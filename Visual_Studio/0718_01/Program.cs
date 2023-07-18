using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0718_01
{
    internal class Program
    {
        static void increase(int count) 
        {
            count++;
        }
        static void Main(string[] args)
        {
            int number = 1;
            increase(number);
            Console.WriteLine(number);
        }
    }
}


