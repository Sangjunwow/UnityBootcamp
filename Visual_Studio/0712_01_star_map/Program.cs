using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0712_01_star
{
    internal class Program //프로그램도 함수지만 ()가 없다
    {
        static int Plusout(int x)
        {
            int y = x + 1;

            return y;
        }


        static void Main(string[] args) //main은 진입점이라 꼭 필요한다. 언어마다 다르기에 각각 외워야함
        {
            /*         //star
                         //입력:5
                         //*****
                         string count = Console.ReadLine(); //readline은 함수. 함수는 카멜케이싱아니라 대문자, 내용이있든없든 ()가 붙는다

                         int writeCount = int.Parse(count); //선은 일차원배열, 면은 이차원배열
                         int[,] data = new int[writeCount, writeCount];

                         for (int y = 1; y <= writeCount; ++y) 
                         {
                             //PrintLine
                             for(int x = 1; x <= writeCount; ++x)
                             {
                                 Console.Write("*"); //다중반복문
                             }
                             Console.WriteLine(""); //줄바꾸기는 *을 안넣는다

                         }*/

            //map제작
            int[,] map = {
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
            };

            int playerX = 1; //플레이어의 위치
            int playerY = 1; //플레이어가 위치에 있으면 그 플레이어 부터 그려라
            while (true)
            {
                //Input()
                ConsoleKeyInfo info = Console.ReadKey(true); //입력 키값을 받는다

               //Process()
                    switch (info.Key)
                    { 
                        case ConsoleKey.LeftArrow:
                        playerX--;
                        break;
                        case ConsoleKey.RightArrow:
                            playerX++;
                            break;
                        case ConsoleKey.UpArrow:
                            playerY--;
                            break;
                        case ConsoleKey.DownArrow:
                            playerY++;
                            break;
                    }
                
                //Render()
                Console.Clear();
                //1:*
                //0:""
                for (int y = 0; y < 10; y++)
                {
                    for (int x = 0; x < 10; x++) // 0 부터 시작
                    {
                        if (playerX == x && playerY == y) //만약 플레이어가 현제 위치랑 같냐? xy위치
                        {// 플레이어보다 맵이 먼저 그려져야하기 때문에 
                            Console.Write("P" + " ");
                        }
                        else if (map[y, x] == 1)
                        {
                            Console.Write("*" + " "); //다중반복문
                        }
                        else if (map[y, x] == 0)
                        {
                            Console.Write(" " + " ");
                        }
                        else
                        {

                        }
                    }
                    Console.WriteLine();
                }
                {
                    //map 최적화
                    //[][][][][][][][][]
                    /* int[] type = new int[10];
                     type[0] = 10;
                     type[1] = 10;
                     type[2] = 10;
                     type[3] = 10;
                     type[4] = 10;
                     type[5] = 10;
                    // type[6] = 10;*/
                    //// int[] type = { 1, 2, 3, 4, 5, 6 }; //위의 공식 최적화 버전



                    //static 자료형 함수이름(인자1, 인자2....)
                    //{
                    //    return 자료형
                    //}

                    ////static을 앞에다 쓴다 지금은
                    //int add(int number1, int number2)
                    //{
                    //    return (number1 + number2); //항상 사칙연산 묶어버리기

                    //}

                    //while (true) 
                    //{
                    //    //input()
                    //    ConsoleKeyInfo info = input();
                    //}

                   

                }


            }
        }
    }
}

