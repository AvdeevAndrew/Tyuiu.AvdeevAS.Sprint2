using Tyuiu.AvdeevAS.Sprint2.Task2.V6.Lib;
namespace Tyuiu.AvdeevAS.Sprint2.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(false, ds.CheckDotInShadedArea(6, 3));
        }
    }
}