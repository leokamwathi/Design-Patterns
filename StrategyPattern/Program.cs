using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interface;
using StrategyPattern.Behaviours;
using StrategyPattern.Behaviours.Display;
using StrategyPattern.Behaviours.Fly;
using StrategyPattern.Behaviours.Quack;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDuck> Ducks = new List<IDuck>
            {
                new Duck("CD CF CQ",new Behaviours.Display.ComplexDisplay(), new Behaviours.Fly.ComplexFly(), new Behaviours.Quack.ComplexQuack()),
                new Duck("SD SF SQ",new Behaviours.Display.SimpleDisplay(), new Behaviours.Fly.SimpleFly(), new Behaviours.Quack.SimpleQuack()),
                new Duck("ND NF NQ",new Behaviours.Display.NoDisplay(), new Behaviours.Fly.NoFly(), new Behaviours.Quack.NoQuack()),
                new Duck("CD SF NQ",new Behaviours.Display.ComplexDisplay(), new Behaviours.Fly.SimpleFly(), new Behaviours.Quack.NoQuack()),
                new Duck("ND CF SQ",new Behaviours.Display.NoDisplay(), new Behaviours.Fly.ComplexFly(), new Behaviours.Quack.SimpleQuack()),
                new Duck("SD NF CQ",new Behaviours.Display.SimpleDisplay(), new Behaviours.Fly.NoFly(), new Behaviours.Quack.ComplexQuack())
            };

            foreach (IDuck Duck in Ducks)
            {
                Duck.Details();
            }
            Console.ReadKey();
        }
    }

    public class Duck : IDuck
    {
        public IFlyBehaviour Fly { get; set; }
        public IQuackBehaviour Quack { get; set; }
        public IDisplayBehaviour Display { get; set; }
        public string Name { get; set; }

        public Duck(string name, IDisplayBehaviour display, IFlyBehaviour fly, IQuackBehaviour quack)
        {
            this.Name = name;
            this.Fly = fly;
            this.Display = display;
            this.Quack = quack;
        }

        public void Details()
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("             " + this.Name + "            ");
            Console.WriteLine("=================================================");
            this.Quack.Quack();
            this.Fly.Fly();
            this.Display.Display();
        }

    }
}
