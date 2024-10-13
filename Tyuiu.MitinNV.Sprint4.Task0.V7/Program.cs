using Tyuiu.MitinNV.Sprint4.Task0.V7.Lib;
namespace Tyuiu.MitinNV.Sprint4.Task0.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Одномерные массивы (статический ввод)                                   *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #7                                                            *");
            Console.WriteLine("* Выполнил: Митин Никита Владимирович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан одномерный целочисленный массив на 10 элементов заполненный статическ*");
            Console.WriteLine("*кими значениями в диапазоне от 0 до 9 подсчитать произведение нечетных эл*");
            Console.WriteLine("*лементов массива.  {9, 8, 7, 9, 5, 4, 3, 2, 3, 7}                        *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int[] a = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };

            var result = ds.GetMultOddArrEl(a);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}