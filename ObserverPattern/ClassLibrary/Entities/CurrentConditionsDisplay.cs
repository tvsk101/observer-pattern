using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Entities
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float currentTemperature;
        private float currentHumidity;
        private float currentPressure;

        public string Display()
        {
            return "Температура: " + currentTemperature 
                + "\nВлажность: " + currentHumidity
                + "\nДавление: " + currentPressure;
        }

        public void UpDate(Dictionary <string, float> WeatherPair)
        {
            currentTemperature = WeatherPair["currentTemperature"];
            currentHumidity = WeatherPair["currentHumidity"];
            currentPressure = WeatherPair["currentPressure"];
        }
    }
}
