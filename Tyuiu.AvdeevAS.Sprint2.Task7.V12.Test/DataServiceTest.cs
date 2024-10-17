using Tyuiu.AvdeevAS.Sprint2.Task7.V12.Lib;
namespace Tyuiu.AvdeevAS.Sprint2.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = -2;
            double y = 4;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = false;

            Assert.AreEqual(wait, res);
        }
    }
}