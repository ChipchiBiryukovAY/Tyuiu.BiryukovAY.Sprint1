
using Tyuiu.BiryukovAY.Sprint1.Task0.V8.Lib;

//ЗАДАНИЕ
//Написать программу, которая вычисляет выражение 10 / 2 / 4 и печает результат на экране.
namespace Tyuiu.BiryukovAY.Sprint1.Task0.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Бирюков А. Ю. | ПКТб-25-1";
            //Длина строки 75 символов
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Базовые навыки работы в #C                                       *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #0                                                             *");
            Console.WriteLine("* Выполнил: Бирюков Алексей Юрьевич | ПКТб-25-1                          *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 15 / 2 / 4             *");
            Console.WriteLine("* и печает результат на экране.                                          *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* 15 / 2 / 4                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            //Метод Calculate находится в библиотеке Tyuiu.BiryukovAY.Sprint1.Task0.V8.Lib
            //в классе DataService
            Console.WriteLine(ds.Calculate());

            Console.ReadLine();

        }
    }
}



