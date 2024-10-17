using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AvdeevAS.Sprint2.Task3.V21.Lib
{
    public class DataService : ISprint2Task3V21
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 1)
            {
                
                y = x * Math.Pow((x + 9) / (x - 1), x);
            }
            else if (x == 0)
            {
                
                y = (Math.Pow(x, 2) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12);
            }
            else if (-25 < x && x < 2)
            {
                // y = (1 + 1 / x^2) ^ x
                y = Math.Pow(1 + (1 / Math.Pow(x, 2)), x);
            }
            else if (x < -25)
            {
                // y = x + 10x - (1 / x)
                y = x + 10 * x - (1 / x);
            }
            else
            {
                // Если ни одно условие не подошло, значение y не определено
                y = double.NaN; // Возвращаем "не число", если условия не выполняются
            }

            return Math.Round(y, 3);
        }
    }
 }

