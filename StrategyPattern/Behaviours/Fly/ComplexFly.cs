using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviours.Fly
{
    class ComplexFly : Interface.IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Complex Flying");
        }
    }
}
