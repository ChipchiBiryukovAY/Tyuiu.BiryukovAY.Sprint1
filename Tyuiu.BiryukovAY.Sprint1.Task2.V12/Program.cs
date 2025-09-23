using Tyuiu.BiryukovAY.Sprint1.Task2.V12.Lib;

internal class Program
{
    static void Main()
    {
        DataService geometry = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите значение длины:");
        int длина = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите значение ширины:");
        int ширина = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите значение высоты:");
        int высота = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int volume = geometry.CalculateParallelepipedVolume(длина, высота, высота);
        Console.WriteLine("Объем = " + geometry.CalculateParallelepipedVolume(длина, высота, высота));

        Console.ReadLine();
    }
}