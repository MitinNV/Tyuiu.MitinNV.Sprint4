using Tyuiu.MitinNV.Sprint4.Task1.V4.Lib;

namespace Tyuiu.MitinNV.Sprint4.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var varForTest = 3;
            var gaga = new int[] { 1, 2, 3 };
            Assert.AreEqual(varForTest, ds.Calculate(gaga));
        }
    }
}