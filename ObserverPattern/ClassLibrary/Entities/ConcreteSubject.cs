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
        private string _state;
        private List<IObserver> observers = new List<IObserver>();

        public void NotifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.upDate();
            }
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
            return _state;
        }

        public void SetState(string StateName)
        {
            _state = StateName;
            NotifyObserver();
        }
    }
}
