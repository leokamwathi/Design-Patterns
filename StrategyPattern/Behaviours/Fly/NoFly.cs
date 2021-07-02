using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviours.Fly
{
    class NoFly : Interface.IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("No Flying");
        }
    }
}
