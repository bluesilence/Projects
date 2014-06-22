using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Bark : SoundBehavior
    {
        public void MakeSound()
        {
            Console.WriteLine("Bark!");
        }

        public string Describe()
        {
            return "Bark";
        }
    }
}
