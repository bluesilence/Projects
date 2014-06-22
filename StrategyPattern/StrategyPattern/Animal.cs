using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    abstract class Animal
    {
        protected string name;
        protected SoundBehavior soundBehavior;

        public abstract void Display();

        public void MakeSound()
        {
            soundBehavior.MakeSound();
        }

        public void SetSoundBehavior(SoundBehavior sb)
        {
            Console.WriteLine("Change {0}'s soundBehavior to {1}", name, sb.Describe());
            this.soundBehavior = sb;
        }
    }
}
