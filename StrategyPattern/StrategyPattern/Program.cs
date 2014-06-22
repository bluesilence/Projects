using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = { new Cat("Mimi"), new Dog("White") };

            DisplayAndMakeSound(animals);

            animals[0].SetSoundBehavior(new Bark());
            animals[1].SetSoundBehavior(new Meow());

            DisplayAndMakeSound(animals);
        }

        static void DisplayAndMakeSound(Animal[] animals)
        {
            foreach (Animal a in animals)
            {
                a.Display();
                a.MakeSound();
            }
        }
    }
}
