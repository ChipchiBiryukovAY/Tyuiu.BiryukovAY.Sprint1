using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BiryukovAY.Sprint1.Task1.V8.Lib
{
    public class DataService : ISprint1Task1V8
    {
        public double Calculate(double y, double x)
        {
            double res = (x * Math.PI) / y;
            return Math.Round(res, 2);
        }
    }
}
