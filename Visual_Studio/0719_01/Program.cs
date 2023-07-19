using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Hp = 10;
            player.Mp = 120;
            Console.WriteLine(player.Hp);
            player.Move();
            player = null;

            Goblin goblin = new Goblin();
            goblin.Attack();
            goblin.Move();
            goblin = null;
        }
    }
}
