using Tyuiu.GrigorenkoMR.Sprint4.Task4.V10.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint4.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mtrx = new int[5, 5] {
                { 6, 6, 5, 3, 3 },
                { 5, 7, 4, 6, 4 },
                { 1, 2, 4, 1, 5 },
                { 1, 7, 2, 5, 7 },
                { 4, 2, 6, 5, 6 }
            };
            int[,] expected = new int[5, 5] {
                { 6, 6, 0, 0, 0 },
                { 0, 0, 4, 6, 4 },
                { 0, 2, 4, 0, 0 },
                { 0, 0, 2, 0, 0 },
                { 4, 2, 6, 0, 6 }
            };
            int[,] actual = ds.Calculate(mtrx);

            // Побайтово сравниваем массивы
            CollectionAssert.AreEqual(expected, actual, "Массивы не совпадают. Нечетные элементы не были заменены на 0.");
        }
    }
}