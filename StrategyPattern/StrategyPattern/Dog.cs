using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Dog : Animal
    {
        public Dog(string name)
        {
            this.name = name;
            this.soundBehavior = new Bark();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a dog named {0}", name);
        }
    }
}
