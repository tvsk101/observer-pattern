using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Entities
{
    public class ConcreteObserver : IObserver
    {
        private int counter = 0;
        public void upDate()
        {
            counter = counter + 1;
        }

        public int GetCounter()
        {
            return counter;
        }
    }
}
