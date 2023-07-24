using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0724_01
{
    class Component
    {
        public GameObject() {
         components = new List<Component>();
    }
        GameObject() {
            components.Clear();
                }

        public List<Component> components;

        public void AddComponent(Component newComponent) { 
        components.Add(newComponent);
        }
        public void RemoveComponent(Component removeComponent)
        {
            components.Remove(removeComponent);
        }
    }
}
