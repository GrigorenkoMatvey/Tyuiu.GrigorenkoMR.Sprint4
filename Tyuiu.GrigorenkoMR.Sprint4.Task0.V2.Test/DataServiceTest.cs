using Tyuiu.GrigorenkoMR.Sprint4.Task0.V2.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint3.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();
            int[] array = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };

            int expected = 44; // 5+3+7+1+3+9+7+9
            int actual = ds.GetSumOddArrEl(array);

            Assert.AreEqual(expected, actual);
        }
    }
}