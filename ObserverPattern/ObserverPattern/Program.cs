﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Entities;
using ClassLibrary.Interfaces;
using ClassLibrary.Subject;


namespace ObserverPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay();
            ForecastDisplay forecastDisplay = new ForecastDisplay();
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay();

            List<IDisplayElement> displays = new List<IDisplayElement>()
            {
                currentConditionsDisplay,
                forecastDisplay,
                statisticsDisplay
            };

            weatherData.RegisterObserver(currentConditionsDisplay);
            weatherData.RegisterObserver(forecastDisplay);
            weatherData.RegisterObserver(statisticsDisplay);

            foreach (IDisplayElement observer in displays)
            {
                Console.WriteLine(observer.Display());
            }

            weatherData.MeasurementsChanged();

            foreach (IDisplayElement observer in displays)
            {
                Console.WriteLine(observer.Display());
            }

            Console.ReadKey();
        }
    }
}
