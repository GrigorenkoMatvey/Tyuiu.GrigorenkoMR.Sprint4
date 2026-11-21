using Tyuiu.GrigorenkoMR.Sprint4.Task5.V14.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint4.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[3, 3] {
                { -1, 2, 3 },
                { -4, 5, -6 },
                { 7, 8, 9 }
            };
            int res = ds.Calculate(mtrx);
            Assert.AreEqual(6, res);
        }
    }
}