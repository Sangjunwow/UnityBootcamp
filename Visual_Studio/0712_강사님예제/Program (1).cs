using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230712
{
    internal class Program
    {
        static int[,] map = {
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

        static int playerX = 5;
        static int playerY = 3;

        static ConsoleKeyInfo Input()
        {
            return Console.ReadKey(true);
        }

        static void Process(ConsoleKey key)
        {
            switch (key)
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
        }

        static void Render()
        {
            Console.Clear();
            //1 : *
            //0 : " "
            for (int y = 0; y < 10; ++y)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (playerX == x && playerY == y)
                    {
                        Console.Write("P" + " ");
                    }
                    else if (map[y, x] == 1)
                    {
                        Console.Write("*" + " ");
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

        }

        static int Add(int number1, int number2)
        {
            int a = (number1 + number2);

            return a;
        }

        //static 자료형 함수이름(인자1, 인자2.....)
        //{
        //    ㄴㅇ리ㅓㅏ;ㄴㅇㄹ
        //        ㄴㅇ라ㅣ;ㅓㄴㅇㄹㄴㅇㄹ
        //        ㄴㅇㄹㄴㅇㄹ;
        //    return 자료형;
        //}

        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 3));

            //while (true)
            //{
            //    //Input();
            //    ConsoleKeyInfo info = Input();

            //    //Process();
            //    Process(info.Key);

            //    //Render();
            //    Render();
            //}
        }
    }
}
