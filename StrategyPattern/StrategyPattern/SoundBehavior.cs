using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    interface SoundBehavior
    {
        void MakeSound();

        string Describe();
    }
}
