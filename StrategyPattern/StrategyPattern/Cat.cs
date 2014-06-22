using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Cat : Animal
    {
        public Cat(string name)
        {
            this.name = name;
            this.soundBehavior = new Meow();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a cat named {0}", name);
        }
    }
}
