using Tyuiu.GrigorenkoMR.Sprint4.Task6.V23.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint4.Task6.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Григоренко М. Р. | ИСПб - 26 - 1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Массивы строк                                                     *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Григоренко Матвей Романович | ИСПб - 26 - 1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Microsoft, Google, Apple, Amazon,          *");
            Console.WriteLine("* Facebook, Tesla, Netflix] используя класс Array подсчитайте             *");
            Console.WriteLine("* количество элементов, длина которых равна 6.                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] array = { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };

            Console.Write("Массив: ");
            // Выводим массив через запятую для красоты
            Console.WriteLine(string.Join(", ", array));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine("Количество элементов с длиной 6 = " + res);

            Console.ReadKey();
        }
    }
}