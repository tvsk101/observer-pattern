using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Entities
{
    public class ConcreteSubject : ISubject
    {
        private string name;
        private List<IObserver> observers = new List<IObserver>();

        public void NotifyOdserver()
        {
            foreach (IObserver observer in observers) observer.upDate();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public string GetState()
        {
            return name;
        }

        public void SetState(string Name)
        {
            name = Name;
            NotifyOdserver();
        }
    }
}
