using Tyuiu.BiryukovAY.Sprint1.Task6.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("Проверка повторения последнего слова");
        Console.WriteLine("====================================");

        Console.Write("Введите текст: ");
        string text = Console.ReadLine() ?? "";

        bool result = ds.CheckLastWordRepetition(text);

        Console.WriteLine($"\nРезультат проверки: {(result ? "ДА" : "НЕТ")}");

        if (result)
        {
            Console.WriteLine("Последнее слово встречается в тексте еще раз.");
        }
        else
        {
            Console.WriteLine("Последнее слово не повторяется в тексте.");
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}