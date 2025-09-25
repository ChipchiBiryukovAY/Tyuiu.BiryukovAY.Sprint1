using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BiryukovAY.Sprint1.Task7.V11.Lib
{
    public class DataService : ISprint1Task7V11
    {
        public double Calculate(double x, double y)
        {
            // Первая часть: (ln(sin x))^x
            double sinX = Math.Sin(x);
            if (sinX <= 0)
                throw new ArgumentException("sin(x) должен быть положительным для вычисления ln");

            double lnSinX = Math.Log(sinX);
            double part1 = Math.Pow(lnSinX, x);

            // Вторая часть: ln(1 + x²)
            double lnPart = Math.Log(1 + Math.Pow(x, 2));

            // Третья часть: y - √|x|
            double sqrtAbsX = Math.Sqrt(Math.Abs(x));
            double part3 = y - sqrtAbsX;

            // Итоговый результат
            double result = (part1 / lnPart) + part3;

            // Округляем до 3 знаков после запятой
            return Math.Round(result, 3);
        }
    }
}