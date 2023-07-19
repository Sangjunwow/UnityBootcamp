using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class monster
    {
        public monster()
        {
           public int hp = 0;
        public int gold = 0;
        public string name = string.Empty;       };

    ~monster() //생성자 소멸자 자동으로 생성되지만 다적어라. 뻗을때 찾을수있다
    {
    }


    public void Move()
    {
        Console.WriteLine("고블린이 움직인다");
    }
    public void Attack()
    {
        Console.WriteLine("고블린이 공격한다");
    }
    public void Die()
    {
        Console.WriteLine("고블린이 죽는다");
    }
}
}

class Goblin : monster
{
    public 
}