using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player
    {
        public Player() //무조건 생성자를 만들어야한다 < 기본생성자
        {
            Console.WriteLine("플레이어가 생성되었다");
            _hp = 0;
            _mp = 0;
            _gold = 0; //생성자에서 초기화를 시킨다
        }


        ~Player()
        {
            Console.WriteLine("플레이어가 삭제되었다");
        }

        public int Hp
        {
            get
            {
                return _hp;
            }
            set
            {
                if (value > 0)
                {
                    _hp = value;
                }
            }
        }

        //property 다 private 수업때만 public

        public int Mp
        {
            get; 
            set;
        }
        // 접근자< 함수



        public int _hp = 0; //함수호출시 안이뻐서 _입력, 언더바로 하면 안써도 자동으로 연결해줌
        public int _mp = 0;
        public int _gold = 0;

        public void Move()
        {
            Console.WriteLine("플레이어가 움직인다");
        }
        public void Attack()
        {
            Console.WriteLine("플레이어가 공격한다");
        }
        public void Die()
        {
            Console.WriteLine("플레이어가 죽는다");
        }
    };

    class Goblin
    {
        public Goblin() //무조건 생성자를 만들어야한다 < 기본생성자
        {
            Console.WriteLine(" 생성되었다");
        }
        public int hp = 0;
        public int mp = 0;
        public int gold = 0;

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
   

           // private void //private은 나만쓸수있어서 객체지향 작업시 남들이 함수호출이 안된다

}