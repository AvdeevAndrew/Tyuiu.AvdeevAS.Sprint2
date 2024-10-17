using Tyuiu.AvdeevAS.Sprint2.Task6.V12.Lib;
namespace Tyuiu.AvdeevAS.Sprint2.Task6.V12
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
            Console.WriteLine("*                              Задание #3                                 *");
            Console.WriteLine("*                              Вариант #21                                *");
            Console.WriteLine("* Выполнил: Авдеев Андрей Сергеевич    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("*      Написать программу, которая отвечает всем требованиям задания.     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                               ИСХОДНЫЕ ДАННЫЕ:                          *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите год (g): ");
            int g = int.Parse(Console.ReadLine());

            Console.Write("Введите месяц (m): ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите число (n): ");
            int n = int.Parse(Console.ReadLine());

        



            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            // Вычисление предыдущего дня
            

            Console.WriteLine($"Предыдущий день: {ds.FindDateOfPreviousDay(g, m, n)}");

            Console.ReadKey();
        }
    }
}
