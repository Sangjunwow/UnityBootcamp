using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0725_02_
{
    class Wdata //클래스
    {
        public int month;
        public int day;
        public string sky;
    }

    class Weather //객체
    {
        static void Main()
        {
            Wdata today = new Wdata(); //인스턴트화
            today.month = 10; //대입
            today.day = 9;
            today.sky = "맑음";
            Console.WriteLine(today.month + "월" + today.day + "일" + today.sky);
        }

    }
 }
