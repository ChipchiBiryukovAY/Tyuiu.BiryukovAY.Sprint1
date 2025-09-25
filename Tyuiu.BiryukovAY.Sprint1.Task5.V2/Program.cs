using System;
using Tyuiu.BiryukovAY.Sprint1.Task5.V2.Lib;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Преобразование Фаренгейт → Цельсий");
        Console.Write("Введите температуру в °F: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Преобразуем и выводим результат
        int celsius = FahrenheitToCelsius(fahrenheit);
        Console.WriteLine($"Температура в °C: {celsius}");
    }

    public static int FahrenheitToCelsius(double fahrenheit)
    {
        double celsius = (fahrenheit - 32) * 5 / 9;
        return Convert.ToInt32(celsius);
    }
} 