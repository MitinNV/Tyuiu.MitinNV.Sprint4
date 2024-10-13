using Tyuiu.MitinNV.Sprint4.Task0.V7.Lib;

namespace Tyuiu.MitinNV.Sprint4.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var varForTest = 178605;
            int[] a = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };
            Assert.AreEqual(varForTest, ds.GetMultOddArrEl(a));
        }
    }
}