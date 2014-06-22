using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Meow : SoundBehavior
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow~");
        }

        public string Describe()
        {
            return "Meow";
        }
    }
}
