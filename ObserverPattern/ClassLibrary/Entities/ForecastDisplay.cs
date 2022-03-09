using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Entities
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float temperatureForecast;
        private float humidityForecast;
        private float pressureForecast;

        public string Display()
        {
            return "Температура (прогноз): " + temperatureForecast
                + "\nВлажность (прогноз): " + humidityForecast
                + "\nДавление (прогноз): " + pressureForecast;
        }

        public void UpDate(Dictionary<string, float> WeatherPair)
        {
            temperatureForecast = WeatherPair["temperatureForecast"];
            humidityForecast = WeatherPair["humidityForecast"];
            pressureForecast = WeatherPair["pressureForecast"];
        }
    }
}
