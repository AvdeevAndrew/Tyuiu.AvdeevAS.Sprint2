using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AvdeevAS.Sprint2.Task2.V6.Lib
{
    public class DataService : ISprint2Task2V6
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x >= 3 && x <= 5) && (y >= 3 && y <= 7))
            {
                return true;
            }
            if ((x >= 6 && x <= 9) && (y >= 5 && y <= 11))
            {
                return true;
            }
            if ((x >= 3 && x <= 12) && (y == 11))
            {
                return true;
            }
            if ((x >= 7 && x <= 10) && (y == 12))
            {
                return true;
            }
            if ((x == 9) && (y <= 4 && y >= 3))
            {
                return true;
            }
            if ((x == 10) && (y <= 7 && y >= 5))
            {
                return true;
            }

            return false;
        }
    }
}
