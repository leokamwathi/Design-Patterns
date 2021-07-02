using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviours.Display
{
    class NoDisplay : Interface.IDisplayBehaviour
    {
        public void Display()
        {
            Console.WriteLine("No Displaying");
        }
    }
}
