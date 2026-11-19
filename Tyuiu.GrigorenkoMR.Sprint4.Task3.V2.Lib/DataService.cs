using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GrigorenkoMR.Sprint4.Task3.V2.Lib
{
    public class DataService : ISprint4Task3V2
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;      
            int columns = matrix.Length / rows;          

            // Берем первый элемент первой строки за начальный максимум
            int max = matrix[0, 0];
            for (int j = 1; j < columns; j++)
            {
                if (matrix[0, j] > max)
                {
                    max = matrix[0, j];
                }
            }

            return max;
        }
    }
}