using Tyuiu.AvdeevAS.Sprint2.Task4.V7.Lib;
namespace Tyuiu.AvdeevAS.Sprint2.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(1030, ds.Calculate(10,1));
        }
    }
}