using Tyuiu.MitinNV.Sprint4.Task4.V23.Lib;
namespace Tyuiu.MitinNV.Sprint4.Task4.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Двумерные массивы. (ввод с клавиатуры)                                  *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Митин Никита Владимирович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значения*");
            Console.WriteLine("*ями с клавиатуры в диапазоне от 3 до 8. Найдите сумму нечетных элементов *");
            Console.WriteLine("* массива.                                                                *");

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
            int[,] data = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                var a = Console.ReadLine();
                int j = 0;
                foreach (var item in a.Split(", "))
                {
                    if (item == "") {
                        continue;
                    }
                    data[i, j] = Convert.ToInt32(item[0]);
                    j++;
                }
            }
            Console.WriteLine(ds.Calculate(data));
            Console.ReadKey();
        }
    }
}