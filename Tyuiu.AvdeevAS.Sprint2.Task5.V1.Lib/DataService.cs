using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AvdeevAS.Sprint2.Task5.V1.Lib
{
    public class DataService : ISprint2Task5V1
    {
        public int FindMonthDaysCount(int value)
        {
            int days;

            switch (value)
            {
                case 1: // Январь
                case 3: // Март
                case 5: // Май
                case 7: // Июль
                case 8: // Август
                case 10: // Октябрь
                case 12: // Декабрь
                    days = 31;
                    break;

                case 4: // Апрель
                case 6: // Июнь
                case 9: // Сентябрь
                case 11: // Ноябрь
                    days = 30;
                    break;

                case 2: // Февраль
                    
                        days = 28;
                    
                    break;

                default:
                    // Если номер месяца некорректен
                    days = -1;
                    break;
            }

            return days;
        }
    }
}
