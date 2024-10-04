using Tyuiu.AvdeevAS.Sprint2.Task1.V11.Lib;
namespace Tyuiu.AvdeevAS.Sprint2.Task1.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Авдеев А.С. | ИБКСБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  Спринт #2                              *");
            Console.WriteLine("* Тема: <Опрации сравнения>                                               *");
            Console.WriteLine("*                              Задание #0                                 *");
            Console.WriteLine("*                              Вариант #29                                *");
            Console.WriteLine("* Выполнил: Авдеев Андрей Сергеевич    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("*      Написать программу, которая отвечает всем требованиям задания.     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                               ИСХОДНЫЕ ДАННЫЕ:                          *");
            Console.WriteLine("***************************************************************************");

            int x = 105;
            int y = 735;
            int v = 105;
            int z = 735;


            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);




            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetLogicOperations(x, y,v ,z));

            Console.ReadKey();
        }
    }
}
