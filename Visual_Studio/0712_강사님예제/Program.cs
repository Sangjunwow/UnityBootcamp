using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230712
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            int playerX = 5;
            int playerY = 3;

            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey(true);

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
        }
    }
}
