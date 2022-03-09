using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Subject
{
    public class WeatherData : ISubject
    {
        private List<string> weatherKeyWords = new List<string>()
        {
            "currentTemperature",
            "currentHumidity",
            "currentPressure",

            "temperatureForecast",
            "humidityForecast",
            "pressureForecast",

            "minTemperature",
            "maxTemperature",
            "averageTemperature",

            "minHumidity",
            "maxHumidity",
            "averageHumidity",

            "minPressure",
            "maxPressure",
            "averagePressure",

            "humidity",
            "pressure",
        };

        List<IObserver> observers = new List<IObserver>();

        Dictionary<string, float> weatherPair = new Dictionary<string, float>();

        public WeatherData()
        {
            MeasurementsChanged();
        }

        public void MeasurementsChanged()
        {
            Random random = new Random();

            foreach (string key in weatherKeyWords)
            {
                this[key] = random.Next(1, 100);
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

        public void NotifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.UpDate(weatherPair);
            }
        }
        public int this[string weatherData]
        {
            set
            {
                weatherPair[weatherData] = value;
                this.NotifyObserver();
            }
        }
    }
}
