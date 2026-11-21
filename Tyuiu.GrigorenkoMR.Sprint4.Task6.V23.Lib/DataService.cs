using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GrigorenkoMR.Sprint4.Task6.V23.Lib
{
    public class DataService : ISprint4Task6V23
    {
        public int Calculate(string[] arrayStrings)
        {
            string[] mas = Array.FindAll(arrayStrings, x => x.Length == 6);
            return mas.Length;
        }
    }
}