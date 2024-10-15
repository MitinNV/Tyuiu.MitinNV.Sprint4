using Tyuiu.MitinNV.Sprint4.Task6.V9.Lib;

namespace Tyuiu.MitinNV.Sprint4.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var varForTest = 3;
            var a = new string[] { "Красный", "Оранжевый", "Желтый", "Зеленый", "Синий", "Индиго", "Фиолетовый" };
            Assert.AreEqual(varForTest, ds.Calculate(a));
        }
    }
}