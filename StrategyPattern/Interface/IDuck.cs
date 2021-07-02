using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interface
{
    public interface IDuck
    {
        IDisplayBehaviour Display { set; get; }
        IFlyBehaviour Fly { set; get; }
        IQuackBehaviour Quack { set; get; }
        string Name { set; get; }

        void Details();
        //void Duck(IDisplayBehaviour Display, IFlyBehaviour Fly, IQuackBehaviour Quack);

    }
}
