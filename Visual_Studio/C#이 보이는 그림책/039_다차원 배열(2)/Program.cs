using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039_다차원_배열_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //재그 배열
            int[][] a = new int[3][]; //3은 최초 차원의 크기(요소 수)
            a[0] = new int[3] { 10, 20, 30 };
            a[1] = new int[2] { 40, 50 };
            a[2] = new int[1] { 60 };

            /*int[][] a = new int[][]
            {
                new int[] { 10, 20, 30 },
                new int[] { 40, 50 },
                new int[] { 60 },
            }; 
            //이런식으로 선언과 동시에 초기화 할수도있다
*/
                        int[] b = new int[4];
                        int c = b.Length;
                        Console.WriteLine(c);

                        int[,] d = new int[3, 2];
                        int e = d.Length;
                        Console.WriteLine(e);

                        int[][] f = new int[][] {
                         new int[] { 10, 20, 30 },
                        new int[] { 40, 50 } };
                        int g = f.Length;
                        int h = f[0].Length; //[]안에 첨자
                        Console.WriteLine(g);
                        Console.WriteLine(h);
        }
    }
}
