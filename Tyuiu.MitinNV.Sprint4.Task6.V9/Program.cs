using Tyuiu.MitinNV.Sprint4.Task6.V9.Lib;
namespace Tyuiu.MitinNV.Sprint4.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Класс Array                                                             *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                            *");
            Console.WriteLine("* Выполнил: Митин Никита Владимирович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан строковый массив данных  ['Красный', 'Оранжевый', 'Желтый', 'Зеленый'*");
            Console.WriteLine("*', 'Синий', 'Индиго', 'Фиолетовый'] используя класс Array подсчитайте кол*");
            Console.WriteLine("*личество элементов, длина которых меньше 7.                              *");

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
            var a = new string[] { "Красный", "Оранжевый", "Желтый", "Зеленый", "Синий", "Индиго", "Фиолетовый" };
            var result = ds.Calculate(a);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}