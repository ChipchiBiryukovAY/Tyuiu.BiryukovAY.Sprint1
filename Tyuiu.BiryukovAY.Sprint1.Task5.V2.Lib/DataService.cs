using tyuiu.cources.programming.interfaces.Sprint1;
using System;


namespace Tyuiu.BiryukovAY.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToCelsius(double fahrenheit)
        {
            return Convert.ToInt32((fahrenheit - 32) * 5 / 9);
        }
    }
}
