using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Entities
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float minTemperature;
        private float maxTemperature;
        private float averageTemperature;

        private float minHumidity;
        private float maxHumidity;
        private float averageHumidity;

        private float minPressure;
        private float maxPressure;
        private float averagePressure;

        public string Display()
        {
            return "Температура (мин): " + minTemperature
                + "\nТемпература (макс): " + maxTemperature
                + "\nТемпература (средн): " + averageTemperature

                + "\nВлажность (мин): " + minHumidity
                + "\nВлажность (макс): " + maxHumidity
                + "\nВлажность (средн): " + averageHumidity

                + "\nДавление (мин): " + minPressure
                + "\nДавление (макс): " + maxPressure
                + "\nДавление (средн): " + averagePressure;
        }

        public void UpDate(Dictionary<string, float> WeatherPair)
        {
            minTemperature = WeatherPair["minTemperature"];
            maxTemperature = WeatherPair["maxTemperature"];
            averageTemperature = WeatherPair["averageTemperature"];

            minHumidity = WeatherPair["minHumidity"];
            maxHumidity = WeatherPair["maxHumidity"];
            averageHumidity = WeatherPair["averageHumidity"];

            minPressure = WeatherPair["minPressure"];
            maxPressure = WeatherPair["maxPressure"];
            averagePressure = WeatherPair["averagePressure"];
        }
    }
}
