using Tyuiu.BiryukovAY.Sprint1.Task3.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        {
            static void Main(string[] args)
            {
                DataService ds = new DataService();

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");

                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите трехзначное число:  " + number);
                if (number < 100 || number > 999)
                {
                    Console.WriteLine("Ошибка! Введите число от 100 до 999");
                    return;
                }
                var lib = new DataService();
                double result = lib.ReverseNumber(number);
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                Console.WriteLine("Число задом = " + ds.ReverseNumber(number));

                Console.ReadKey();

            }
        }
    }
}