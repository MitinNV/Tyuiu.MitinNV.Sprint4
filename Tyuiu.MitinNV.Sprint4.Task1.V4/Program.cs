using Tyuiu.MitinNV.Sprint4.Task1.V4.Lib;
namespace Tyuiu.MitinNV.Sprint4.Task1.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Одномерные массивы. (ввод с клавиатуры)                                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #4                                                            *");
            Console.WriteLine("* Выполнил: Митин Никита Владимирович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан одномерный целочисленный массив на 10 элементов заполненный значениям*");
            Console.WriteLine("*ми с клавиатуры в диапазоне от 1 до 9 подсчитать произведение нечетных эл*");
            Console.WriteLine("*лементов массива.  С клавиатуры: 1, 2, 5, 3, 4, 7, 8, 8, 3, 9            *");

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