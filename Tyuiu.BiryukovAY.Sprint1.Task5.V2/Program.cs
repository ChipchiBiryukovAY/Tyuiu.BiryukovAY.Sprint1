using System;
using Tyuiu.BiryukovAY.Sprint1.Task5.V2.Lib;

internal class Program
{
    static void Main()
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите температуру в градусах Фаренгейта:");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Температура в градусах Цельсия:");
        int celsius = Converter.FahrenheitToCelsius(fahrenheit);
        Console.WriteLine(celsius);

        Console.ReadKey();

    }
}
}