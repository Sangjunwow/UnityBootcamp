using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0718_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            state[] states = new state[4];
            transition[] transitions = new transition[5];

            states[0] = new state[0];
            states[0].id = 1;
            states[0].stateName = "배회";
            states[0] = new state[0];
            states[1].id = 2;
            states[1].stateName = "추격 ";
            states[0] = new state[0];
            states[1].id = 2;
            states[1].stateName = "공격";
            states[1].id = 2;
            states[0] = new state[0];
            states[1].stateName = "죽음";

            transitions[0].currentState = 1;
            transitions[0].condition = "적발견";
            transitions[0].nextState = 2;
            transitions[0].currentState = 2;
            transitions[0].condition = "적놓침";
            transitions[0].nextState = 3;
            transitions[0].currentState = 3;
            transitions[0].condition = "사정거리접근";
            transitions[0].nextState = 2;
            transitions[0].currentState = 1;
            transitions[0].condition = "사정거리이탈";
            transitions[0].nextState = 2;
            transitions[0].currentState = 1;
            transitions[0].condition = "hp없음";

            int MonsterCurrentState = 1;
            string MonsterCondition = "적발견";
            int MonsterNextState = 0;

            for (int i = 0; i < transition.Length; ++i)
            {
                if (MonsterCurrentState == transitions[i].currentState &&
                    MonsterCondition == transitions[i].) { }
            }
;


        }
    }
}
