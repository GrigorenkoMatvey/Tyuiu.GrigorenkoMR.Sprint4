using Tyuiu.GrigorenkoMR.Sprint4.Task0.V2.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint4.Task0.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Григоренко М. Р. | ИСПб - 26 - 1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический вывод)                            *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Григоренко Матвей Романович | ИСПб - 26 - 1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму нечетных *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("* Массив: {5, 3, 7, 1, 3, 9, 8, 7, 9, 4}                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };

            Console.Write("Массив: ");
            Console.WriteLine(string.Join(", ", array));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int sum = ds.GetSumOddArrEl(array);
            Console.WriteLine("Сумма нечетных элементов = " + sum);

            Console.ReadKey();
        }
    }
}
