using Tyuiu.GrigorenkoMR.Sprint4.Task6.V23.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint4.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };
            int res = ds.Calculate(array);
            Assert.AreEqual(2, res);
        }
    }
}