using tyuiu.cources.programming.interfaces.Sprint1;
using System;

namespace Tyuiu.BiryukovAY.Sprint1.Task5.V2.Lib
{
    public class TemperatureConverter : ISprint1Task5V2
    {
        public int FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            int result = (int)Math.Round(celsius, MidpointRounding.AwayFromZero);
            return result;
        }
    }
}
