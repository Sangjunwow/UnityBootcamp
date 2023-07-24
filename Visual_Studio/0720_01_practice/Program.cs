using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0720_01_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//pg.70 
             if{
                int a = 5;
                if (a % 2 == 0)
                    Console.WriteLine(a + "는 짝수입니다.");
                else
                    Console.WriteLine(a + "는 홀수입니다.");
            }
    */

            /* 
             int s = 65;
             Console.WriteLine("당신의 점수는" + s + "점입니다.");
             if (s < 70)
             { // {}을 하나로 묶는것을 블록이라고 한다
                 Console.WriteLine("평균까지 앞으로" + s + "점입니다.");
                 Console.WriteLine("분발하세요!");
             }
             else
             {
                 Console.WriteLine("잘 했습니다!");
             }
 */
            /* //pg.72  
             int num = 1000;
                Console.Write(num + "는");

                if(0<num&&num <=9)
                    Console.WriteLine("1자리의 수 입니다.");
                else if (10 < num && num <= 99)
                    Console.WriteLine("2자리의 수 입니다.");
                else if (100 < num && num <= 999)
                    Console.WriteLine("3자리의 수 입니다.");
                else Console.WriteLine("4자리의 수 입니다.");
            }
    */
            /* int a = 90;
             if (a > 80)
             {
                 if (a == 100)
                     Console.WriteLine("만점입니다.");
                 else
                     Console.WriteLine("조금만 더!");
             }
             else
                 Console.WriteLine("분발하십시오.");
         }
 */
            //pg.74 for문
            /*   int i;//카운터
               for (i = 1; i < 4; i++)//(카운터초기값; 반복유무를 결정할 조건; 카운터를 증가시키는 조건)
                   Console.WriteLine("안녕하세요" + i);//반복하는것이 루프
           }*/
            /* int i, j; //이중루프에선 카운터는 두종류 필요하다
             for (j = 8; j <= 9; j++)//바깥쪽루프
                 for (i = 1; i <= 9; i++)//안쪽루프
                     Console.WriteLine(j + "x" + i + "=" + j * i);
         }
 */
            /*//pg.76 foreach???????
            int[] yahoo = { 1, 2, 3, 4 };

            foreach (int a in yahoo)
                Console.WriteLine(a);
*/
            //pg.78 while
            /*int i = 100;
            while (i <= 3) //이미 조건에 벗어나 출력되지안는다
            {
                Console.WriteLine("hey");
                i++;
            }
            do //do~while은 조건에 벗어난 동일조건이지만 일단 한번은 작동한다
            {
                Console.WriteLine("Do hey");
                i++;
            } while (i <= 3);*/
            /*int s = 0, i = 0;
            do
            {
                ++i;
                s += i;//s+i의 값을 s에 대입
            } while (i < 10);
            Console.WriteLine("1부터 "+i+" 까지의 합은" +s);
*/
            /*  int a, b = 2;
          for(a = 0; a < 5; a++)
          {
              if (b - a <= 0) //b-a값이 0이하가 되면 루프를 종료한다
                  break; //break를 만나면 가장 가까운 블록의 끝으로 실행을 넘겨준다. 복수의 블록을 못넘는다
              Console.WriteLine(b+"-"+a+"="+(b-a));
          }
          int c, d = 1;
          for(c=0; c < 4; c++)
          {
              if (c + d == 2)//a+b=2일때 루프의 시작으로 돌아감. 즉 1+1=2는 넘어가고 다름거 진행
                  continue;
              Console.WriteLine(c+"+"+d+"="+(c+d));
          }
*/
            //pg.82 switch
            //switch 문의 식에는 정수형, enum 등 정수형에 준하는 형, char형, string형을 사용할수 있습니다
            //그 외의 겨우에는 대신에 if문을 사용하십시오
            /* int a;
             for (a = 5; a <= 8; a++)
             {
                 Console.WriteLine(a + "/3=" + a / 3);


                 switch (a % 3)
                 {
                     case 1:
                         Console.WriteLine("나머지는 1입니다.");
                         break;
                     case 2:
                         Console.WriteLine("나머지는 2입니다.");
                         break;
                     default:
                         Console.WriteLine("나머지는 0입니다.");
                         break;
                 }
             }
 */
            //pg.84 적의 좌표가 사정거리 안에 있는지
            /*int[] myPos = { 20, 30 }; // 자신이 있는 위치
            int[,] enemyPos = { //적의 위치
                { 2, 4 },
                { 10, 6 },
                { 25, 20 },
            };
            int i;
            int dx, dy;
            double d;
            double r = 15; //사정거리
            for (i = 0; i < 3; i++)
            {
                dx = myPos[0] - enemyPos[i, 0];
                dy = myPos[0] - enemyPos[i, 1];
                d = (double)(dx * dx + dy * dy);
                if (d > r * r)
                {
                    Console.WriteLine("적" + i + "은(는) 사정권 밖에 있음");
                }
                else
                {
                    Console.WriteLine("적" + i + "은(는) 사정권 안에 있음");
                }
            }
*/
            //pg.85 막대그래프를 표시한다
            string[] names =
            {
                "홍길동","김철수","최하니",
                "이길상","권태기","장만옥"
            };
            int[] scores =
            {
                48,75,62,90,84,28
            };
            int i, j;
            string s;
            for (i = 0; i < 6; i++)
            {
                Console.Write(names[i] + " " + scores[i] + " ");
                for (j = 0; j < scores[i] / 5; j++)
                { Console.Write("I"); }
                if (scores[i] < 50)
                    s = "조금 부족";
                else if (scores[i] < 70)
                    s = "보통";
                else if (scores[i] < 90)
                    s = "잘함";
                else
                    s = "매우 잘 함";
                Console.Write(" " + s);
            }
        }
    }
}
