using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230710
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int 정수 숫자 저장공간 4자리 4byte
            //cw tap누르면 바로 완성형으로 console.ReadLine();
            //camelcase 처럼 int 쓸때엔 앞에 소문자 다른문자 나올땐 대문자
            int numberOfMoney = 10;
            int numberOfMana = 20;

            string inputValue = Console.ReadLine();
            Console.WriteLine(int.Parse(inputValue) + numberOfMana);
        }
    }
}
