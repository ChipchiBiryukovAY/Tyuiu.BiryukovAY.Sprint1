using Tyuiu.BiryukovAY.Sprint1.Task4.V30.Lib;
internal class Program
{
  
        static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("Введите значение X:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение Y:");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        double result = (x + Math.Pow(y, 3)) / Math.Exp(2 - y);
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("(x + y ^ 3) / (e ^ (2 - y)) = " + Math.Round(result, 3));

        Console.ReadKey();
    }
}