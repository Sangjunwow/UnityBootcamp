using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230717
{
    internal class Program
    {
        //c
        static void Swap(ref int x,  ref int y)
        {
            int c = 0;
            c = y;
            y = x;
            x = c;
        }

        //sum, avg;

        static void Calculate(int a, int b, out int outSum, out float outAvg)
        {
            outSum = a + b;
            outAvg = (float)outSum / 2.0f;
        }
       
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;

            Swap(ref a, ref b);

            int sum = 100;
            float avg = 0;
            Calculate(a, b, out sum, out avg);

            Console.WriteLine(sum);
            Console.WriteLine(avg);

        }
    }
}
