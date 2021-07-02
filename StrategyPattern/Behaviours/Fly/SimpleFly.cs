using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviours.Fly
{
    class SimpleFly : Interface.IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Simple Flying");
        }
    }
}
