internal class Program
{
    private static void Main()
    {
        DataService ds = new DataService();

        Console.WriteLine("Вычисление математического выражения");
        Console.WriteLine("z = (((ln(sin x))^x) / (ln(1 + x²))) + (y - √|x|)");
        Console.WriteLine("==================================================");

        // Ввод данных от пользователя
        Console.Write("Введите значение x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        // Вычисление результата
        double result = dataService.Calculate(x, y);

        // Вывод результата
        Console.WriteLine($"\nРезультат: z = {result:F3}");
        Console.ReadKey();
    }
}