using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0801_01_practice
{
    class Book
    {
        public int price;
        public int num = 0;
        public string title;

        public Book(string t, int p)
        {
            title = t;
            price = p;
        }
        public void print()
        {
            Console.WriteLine("제    목: " + title);
            Console.WriteLine("정    가: " + price);
            Console.WriteLine("주문 부수: " + num);
            Console.WriteLine("합계 금액: " + price * num);
        }
    }
    class Book2
    {
        static void Main()
        {
            Book book = new Book("C 그림책", 14000);
            book.num = 10;
            book.print();
        }
    }
}

