using ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {

        static Random RandomGenerator = new Random(2345);
        static int Count { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            IObserverable Chatroom = new Observerable();
            List <IObserver> ObserverList = new List<IObserver>();

            ObserverList.Add(new Observer(Chatroom, "John"));
            ObserverList.Add(new Observer(Chatroom, "Mary"));
            ObserverList.Add(new Observer(Chatroom, "Tom"));
            ObserverList.Add(new Observer(Chatroom, "Jane"));
            ObserverList.Add(new Observer(Chatroom, "Sally"));

            while(Count < 100)
            {
                Generate(Chatroom);
            }
            Console.WriteLine("Done");
            Console.ReadKey();
        }

        public static  void Generate(IObserverable observerable)
        {
            int randomNumber = RandomGenerator.Next(100);
            if (randomNumber < 10)
            {
                Console.WriteLine("====================");
                observerable.State = observerable.State + randomNumber;
                observerable.Notify();
                
            }
            Count++;
        }
    }


}
