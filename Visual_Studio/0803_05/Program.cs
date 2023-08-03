using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0803_05
{
    class Cmdline
    {

        static void Main(string[] args)
        {
            int i;
            if (args.Length == 0)
            {
                Console.WriteLine("명령행 인수가 없다.");
            }
            else
            {
                for (i = 0; i < args.Length; i++)
                    Console.WriteLine((i + 1) + " : " + args[i]);


            }
        }
    }
}
