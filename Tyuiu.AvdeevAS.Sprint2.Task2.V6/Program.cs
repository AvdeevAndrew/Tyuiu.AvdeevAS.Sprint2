using Tyuiu.AvdeevAS.Sprint2.Task2.V6.Lib;
namespace Tyuiu.AvdeevAS.Sprint2.Task2.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Авдеев А.С. | ИБКСБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  Спринт #2                              *");
            Console.WriteLine("* Тема: <Опрации сравнения>                                               *");
            Console.WriteLine("*                              Задание #2                                 *");
            Console.WriteLine("*                              Вариант #6                                 *");
            Console.WriteLine("* Выполнил: Авдеев Андрей Сергеевич    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("*      Написать программу, которая отвечает всем требованиям задания.     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                               ИСХОДНЫЕ ДАННЫЕ:                          *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите координату X: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            if (ds.CheckDotInShadedArea(x, y))
            {
                Console.WriteLine($"Точка с координатами ({x}, {y}) находится в заштрихованной области.");
            }
            else
            {
                Console.WriteLine($"Точка с координатами ({x}, {y}) не находится в заштрихованной области.");
            }

            Console.ReadKey();
        }
    }
}
