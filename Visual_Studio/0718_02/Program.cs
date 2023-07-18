using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0718_02
{
    internal class Program //ctrl shift a
    {
        static void Main(string[] args)
        {
            //class custom datatype
            image[] image = new image[100]; //instance를 만든다

            for (int i = 0; i < image.Length; i++)
            {
                image[i].x = 0;
                image[i].y = 0;
                image[i].r = 0;
                image[i].g = 0;
                image[i].b = 0;
            }
            image = null; //gabage collection
            
        }
    }
}
