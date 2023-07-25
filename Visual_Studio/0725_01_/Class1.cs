using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0725_01_
{
    internal class Book
    {
        public int price;
        int a = 5;//필드: 클래스안의 변수, 초기값을 생략한 경우 기본값이된다, 메소드안에서 정의한 변수는 필드라고 하지않는다
        public int num;
        public string title; 

        public int sum()
        {
            return price * num;
        }
    }
}
