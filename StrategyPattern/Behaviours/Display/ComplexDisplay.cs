using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviours.Display
{
    class ComplexDisplay : Interface.IDisplayBehaviour
    {
        public void Display()
        {
            Console.WriteLine("Complex Displaying"); 
        }
    }
}
