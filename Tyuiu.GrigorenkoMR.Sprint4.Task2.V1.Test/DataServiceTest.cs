using Tyuiu.GrigorenkoMR.Sprint4.Task2.V1.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint4.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 10, 15, 13, 6, 8, 18, 12, 13, 7, 15 };
            int expectedResult = 103680;
            int res = ds.Calculate(array);
            Assert.AreEqual(expectedResult, res);
        }
    }
}