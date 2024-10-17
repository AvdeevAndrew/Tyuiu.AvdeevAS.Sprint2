using Tyuiu.AvdeevAS.Sprint2.Task5.V1.Lib;
namespace Tyuiu.AvdeevAS.Sprint2.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService();
            Assert.AreEqual(31, ds.FindMonthDaysCount(3));
        }
    }
}