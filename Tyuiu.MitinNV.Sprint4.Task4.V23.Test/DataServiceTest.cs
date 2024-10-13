using Tyuiu.MitinNV.Sprint4.Task4.V23.Lib;

namespace Tyuiu.MitinNV.Sprint4.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var varForTest = 86;
            int[,] a = { { 9, 7, 4, 9, 7 }, { 5, 2, 5, 7, 6 }, { 8, 3, 3, 5, 7 }, { 8, 4, 2, 4, 5 }, { 8, 8, 9, 5, 6 } };
            Assert.AreEqual(varForTest, ds.Calculate(a));
        }
    }
}