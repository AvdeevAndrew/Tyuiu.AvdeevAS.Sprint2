using Tyuiu.AvdeevAS.Sprint2.Task5.V1.Lib;
namespace Tyuiu.AvdeevAS.Sprint2.Task5.V1
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
            Console.WriteLine("*                              Задание #5                                 *");
            Console.WriteLine("*                              Вариант #1                                 *");
            Console.WriteLine("* Выполнил: Авдеев Андрей Сергеевич    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("*      Написать программу, которая отвечает всем требованиям задания.     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                               ИСХОДНЫЕ ДАННЫЕ:                          *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер месяца (1-12): ");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");


           

            Console.ReadKey();

            

            

            if (ds.FindMonthDaysCount(month) > 0)
            {
                Console.WriteLine($"Количество дней в месяце: {ds.FindMonthDaysCount(month)}");
            }
            else
            {
                Console.WriteLine("Неверный номер месяца. Введите число от 1 до 12.");
            }
        }
    }
}
