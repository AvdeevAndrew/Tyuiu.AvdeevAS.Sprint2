using Tyuiu.AvdeevAS.Sprint2.Task6.V12.Lib;
namespace Tyuiu.AvdeevAS.Sprint2.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService(); // ��� �����, ���������� ����� FindDateOfPreviousDay

            // ���������� � ��������� �����������
            Assert.AreEqual("16.10.2024", ds.FindDateOfPreviousDay(2024,10,17));
        }
    }
}