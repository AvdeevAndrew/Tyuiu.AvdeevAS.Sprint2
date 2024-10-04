using Tyuiu.AvdeevAS.Sprint2.Task0.V29.Lib;
namespace Tyuiu.AvdeevAS.Sprint2.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            CollectionAssert.AreEqual(new bool[] { false, false, true, true, false, false }, ds.GetCompareOperations(105, 735));
        }
    }
}