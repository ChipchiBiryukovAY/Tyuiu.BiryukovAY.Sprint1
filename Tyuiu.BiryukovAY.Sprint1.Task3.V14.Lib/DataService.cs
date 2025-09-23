using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BiryukovAY.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(int number)
        {
            int units = number % 10;        // единицы
            int tens = (number / 10) % 10;  // десятки
            int hundreds = number / 100;    // сотни

            int reversed = units * 100 + tens * 10 + hundreds;
            return reversed;
        }
    }
}
