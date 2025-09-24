using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BiryukovAY.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToCelsius(double fahrenheit)
        {
            // Формула преобразования: C = (F - 32) * 5/9
            double celsius = (fahrenheit - 32) * 5 / 9;

            // Приводим к целому с помощью Convert
            return Convert.ToInt32(celsius);
        }
    }
}
