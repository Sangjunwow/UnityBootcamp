using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0711_06_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //점수를 입력 받았어요
            //A:90~100
            //B:80~90
            //C:70~80
            //D:60~70
            //F: 0~60

            // if > elseif > switch

            //switch문
            int score = 50;
            int scoreDivide = score / 10;
            string grade = "";

            switch (scoreDivide)
            {
                case 10:
                case 9:
                    grade = "A";
                    break;
                case 8:
                    grade = "B";
                    break;
                case 7:
                    grade = "C";
                    break;
                case 6:
                    grade = "D";
                    break;
                default:
                    grade = "F";
                    break;
            }

            switch (scoreDivide)
            {
                case 10:
                case 9:
                    grade = "A";
                    break;
                case 8:
                    grade = "B";
                    break;
                case 7:
                    grade = "C";
                    break;
                case 6:
                    grade = "D";
                    break;
                default:
                    grade = "F";
                    break; //빼먹으면 디폴트 안먹음
            }
            Console.WriteLine(grade);


            //if else
            int score2 = 40;

            if (score2 >= 90)
            {
                Console.WriteLine("A");
            }
            else if (score2 >= 80)
            {
                Console.WriteLine("B");
            }
            else if (score2 >= 70)
            {
                Console.WriteLine("C");
            }
            else if (score2 >= 60)
            {
                Console.WriteLine("D");
            }
            else if (score2 < 60)
            {
                Console.WriteLine("F");
            }

            // if 와  else 반복
            int score3 = 68;

            if (score3 < 60)
            {
                Console.WriteLine("F");
            }
            else
            {
                if (score3 < 70)
                {
                    Console.WriteLine("D");
                }
                else
                {
                    if (score3 < 80)
                    {
                        Console.WriteLine("C");
                    }
                    else
                    {
                        if (score3 < 90)
                        {
                            Console.WriteLine("B");
                        }
                        else
                        {
                            if (score <= 100)
                            {
                                Console.WriteLine("A");
                            }
                        }
                    }
                }
            }
        }
    }
}
