using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviours.Display
{
    class SimpleDisplay : Interface.IDisplayBehaviour
    {
        public void Display()
        {
            Console.WriteLine("Simple Displaying");
        }
    }
}
