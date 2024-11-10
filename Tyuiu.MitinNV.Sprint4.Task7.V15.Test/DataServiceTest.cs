using Tyuiu.MitinNV.Sprint4.Task7.V15.Lib;

namespace Tyuiu.MitinNV.Sprint4.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var varForTest = 4;
            Assert.AreEqual(varForTest, ds.Calculate(4, 2, "10293847"));
        }
    }
}