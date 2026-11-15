using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GrigorenkoMR.Sprint4.Task0.V2.Lib
{
    public class DataService : ISprint4Task0V2
    {
        public int GetSumOddArrEl(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
