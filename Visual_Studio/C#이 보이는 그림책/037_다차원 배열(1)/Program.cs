using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037_다차원_배열_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           int[]a=new int[3]; //1차원 배열
           int[,]a=new int[2,3]; //2차원 배열 y,x
           int[,,]a=new int[2,3,4];//3차원 배열 z,y,x
*/

            int[,] a =
             {
                {10,20},
                {30,40},  // 초기화 {},의 조합에 주의
                {50,60}
                };
            a[1, 1] = 0; //a[1,1]에 0을 대입 
            Console.WriteLine(a[1, 0]);
            Console.WriteLine();

            Console.WriteLine("a[0,0]은" + a[0,0] + '\t' + "a[0,1]은" + a[0,1]); //'\t'는 탭
            Console.WriteLine("a[1,0]은" + a[1,0] + '\t' + "a[1,1]은" + a[1,1]);
            Console.WriteLine("a[2,0]은" + a[2,0] + '\t' + "a[2,1]은" + a[2,1]);

        }
    }
}
