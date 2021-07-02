using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviours.Quack
{
    class NoQuack : Interface.IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("No Quacking");
        }
    }
}
