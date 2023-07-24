using _0724_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0724_01
{
    class FlatEngine

    {
        public FlatEngine //생성자 만들고
            {
            gameObjects = new List<GameObject>();
}
    ~FlatEngine()
    {
        GameObject.clear()
    }
    List<Gameobject> gameObjects;

    void instantiate(GameObject gmamObject);
    }
public void Destory(GameObject removeGameObject)
{ gmaeObjects.Remove(removeGameObject); } //소멸자에서 없앤다
}
