using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0803_02_practice
{
    class Aroma
    {
        public double drop;
        public double itteki { get; set; } //자동구연 속성으로 값을 가져오거나 설정하는거면 이걸로 요약가능
        /*{
            get
            {
                return drop;
            }
            set
            {
                drop = value;
            }
        }*/
    }
    class AromaSample
    {
        static void Main(string[] args)
        {
            Aroma aroma = new Aroma();
            aroma.itteki = 0.01;
            Console.WriteLine("한 방울은 " + aroma.itteki + "ml입니다.");
        }
    }
}
