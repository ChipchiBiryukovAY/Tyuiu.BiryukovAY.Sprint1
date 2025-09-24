using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BiryukovAY.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(double number)
        {
            double units = number % 10;        // единицы
            double tens = (number / 10) % 10;  // десятки
            double hundreds = number / 100;    // сотни

            double reversed = units * 100 + tens * 10 + hundreds;
            return reversed;
        }
    }
}
