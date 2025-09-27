using Tyuiu.BiryukovAY.Sprint1.Task5.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("Преобразование температуры из Фаренгейта в Цельсия");
        Console.WriteLine("=================================================");

        // Запрашиваем у пользователя температуру в Фаренгейтах
        Console.Write("Введите температуру в градусах Фаренгейта: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Преобразуем в Цельсии с помощью метода FahrenheitToCelsius
        int celsius = ds.FahrenheitToCelsius(fahrenheit);

        // Выводим результат
        Console.WriteLine($"Температура в градусах Цельсия: {celsius}°C");
    }
}