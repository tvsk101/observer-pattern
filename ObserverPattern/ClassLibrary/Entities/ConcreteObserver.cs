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
        private int count = 0;
        public void upDate()
        {
            count = count + 1;
        }

        public int GetCounter()
        {
            return count;
        }
    }
}
