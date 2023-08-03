using _0803_06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0803_06
{
    //엔진의 클래스
    class Engine
    {
        string name;
        int size;

        public Engine(string n, int s)
        //생성자
        {
            name = n;
            size = s;
        }

        public int Size
        //배기량을 취득하는 속성
        {
            get
            {
                return size;
            }
        }
    }
}
//자동차 종류의 클래스
class Car
{
    string name;
    Engine engine;

    public Car(string n, Engine e)
    //생성자
    {
        name = n;
        engine = e;
    }
    public void printInfo()
    //정보를 표시하는 메소드
    {
        Console.WriteLine(name + "(" + engine.Size + "cc)");
    }
}
//Main() 메소드의 클래스
class Program
{
    static void Main(string[] args)
    {
        Engine blf = new Engine("BLF", 1597);
        Engine bvy = new Engine("BVY", 1984);
        Engine blg = new Engine("BLG", 1389);

        Car[] cars = new Car[4];
        //car클래스 배열
        cars[0] = new Car("GOLF E", blf);
        cars[1] = new Car("GOLF F", bvy);
        cars[2] = new Car("GOLF G", blg);
        cars[3] = new Car("GOLF H", blf);

        foreach (Car car in cars)
        {
            car.printInfo();
        }
    }
}

