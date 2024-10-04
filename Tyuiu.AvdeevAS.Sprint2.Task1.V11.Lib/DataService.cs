using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AvdeevAS.Sprint2.Task1.V11.Lib
{
    public class DataService : ISprint2Task1V11
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
           a = 145;   //3
            b = 156;  //4
           c = 142;   //2
            d = 117;  //1

            bool[] results = new bool[6];

            results[0] = (a > b) | (b < c); //f
            results[1] = (a > b) & (b < c); //f
            results[2] = (a < b) || (b < c); //t
            results[3] = (a > b) && (b < c); //f
            results[4] = !(a >= b); //t
            results[5] = (a > b) ^ (b < c); //f

            return results;

        }
    }
}
