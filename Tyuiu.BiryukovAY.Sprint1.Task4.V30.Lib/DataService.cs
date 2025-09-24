using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BiryukovAY.Sprint1.Task4.V30.Lib;

public class DataService : ISprint1Task4V30
{
    public double Calculate(double x, double y)
    {
        double numerator = x + Math.Pow(y, 3);
        double denominator = Math.Exp(2 - y);
        double result = numerator / denominator;

        return Math.Round(result, 3);
    }
}
