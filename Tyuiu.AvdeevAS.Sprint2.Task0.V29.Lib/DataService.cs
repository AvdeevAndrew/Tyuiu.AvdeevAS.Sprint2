
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AvdeevAS.Sprint2.Task0.V29.Lib
{
    public class DataService : ISprint2Task0V29
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            
            bool[] results = new bool[6];

            results[0] = x == y; //f
            results[1] = x + 630 != y; //f
            results[2] = x < y; //t
            results[3] = x + 635 > y; //t
            results[4] = x + 635 <= y; //f
            results[5] = x >= y; //f

           return results;
        }
    }
}
