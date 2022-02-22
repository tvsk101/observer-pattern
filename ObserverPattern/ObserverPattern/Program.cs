using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Entities;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteObserver concreteObserver1 = new ConcreteObserver();
            ConcreteObserver concreteObserver2 = new ConcreteObserver();
            ConcreteSubject concreteSubject = new ConcreteSubject();

            concreteSubject.RegisterObserver(concreteObserver1);
            concreteSubject.SetState("Первое состояние");
            Console.WriteLine(concreteObserver1.GetCounter());
            Console.WriteLine(concreteObserver2.GetCounter());
            Console.WriteLine();

            concreteSubject.RegisterObserver(concreteObserver2);
            concreteSubject.SetState("Новое состояние");
            Console.WriteLine(concreteObserver1.GetCounter());
            Console.WriteLine(concreteObserver2.GetCounter());
            Console.WriteLine();


            concreteSubject.RemoveObserver(concreteObserver2);
            concreteSubject.SetState("Стостояние поновее");
            Console.WriteLine(concreteObserver1.GetCounter());
            Console.WriteLine(concreteObserver2.GetCounter());

            Console.ReadKey();
        }

        private static void CounterInConsole(List<ConcreteObserver> observers)
        {
            foreach (ConcreteObserver observer in observers)
            {
                Console.Write(observer.GetCounter() + " ");
            }
            Console.WriteLine();
        }
    }
}
