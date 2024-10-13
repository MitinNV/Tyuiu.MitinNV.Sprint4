using Tyuiu.MitinNV.Sprint4.Task2.V2.Lib;
namespace Tyuiu.MitinNV.Sprint4.Task2.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Одномерные массивы. (генератор случайных чисел)                         *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #2                                                            *");
            Console.WriteLine("* Выполнил: Митин Никита Владимирович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан одномерный целочисленный массив на 11 элементов заполненный случайным*");
            Console.WriteLine("*ми в диапазоне от 1 до 8 подсчитать произведение нечетных элементов масси*");
            Console.WriteLine("*ива.                                                                     *");

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
            string a;
            a = Console.ReadLine();
            var b = new int[a.Split(", ").Count()];
            var i = 0;
            foreach (var item in a.Split(", "))
            {
                b[i] = Convert.ToInt32(item);
                i++;
            }
            var result = ds.Calculate(b);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}