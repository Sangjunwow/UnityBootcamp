using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0711_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int korean0 = 100;
            int english0 = 100;
            int math0 = 10;

            int korean1 = 90;
            int english1 = 70;
            int math1 = 20;

            int korean2 = 90;
            int english2 = 70;
            int math2 = 20;

            int korean3 = 90;
            int english3 = 70;
            int math3 = 20;

            int korean4 = 90;
            int english4 = 70;
            int math4 = 20;
            //위의 번거로운 방법대신

            //배열 , array
            //korean
            //[0][1][2][3][4][5][6][7][8][9]
            int[] korean = new int[10];
            int[] english = new int[10];

            korean[0] = 100;
            korean[1] = 100;
            korean[2] = 100;
            korean[3] = 100;
            korean[4] = 100;
            korean[5] = 100;
            korean[6] = 100;
            korean[7] = 100;
            korean[8] = 100;
            korean[9] = 100; //int[10]을 지정했기에 10까지 하면 에러가 뜬다


            float[] average = new float[10];

            //위의 번거로운 방법대신 상수를 변수로 바꾼다

            // 반복문
            // x를 할당해줘야한다
            int size = 10000;
            int[] korean = new int[size]; //ctrl K D 하면 뛰어쓰기 조절함
            int[] english = new int[10];
            int i = 0;
            for (i = 0; i < 10; i = i + 1) //범위 지정해줌 (초기치, 조건, 증가치)
            {
                korean[i] = 100; //변수 지정시 x가 아니라 i,j,k로 대신씀.. 걍 역사적으로 그럼
            }
            //반복문 기본공식
            //for(초기치; 조건식; 증가치)
            //{
            // 내용
            //}
        }
    }
}
