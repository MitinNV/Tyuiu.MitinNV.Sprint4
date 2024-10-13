using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MitinNV.Sprint4.Task2.V2.Lib
{
    public class DataService : ISprint4Task2V2
    {
        public int Calculate(int[] array)
        {
            int res = 1;
            foreach (var item in array)
            {
                if (item % 2 == 1)
                {
                    res *= item;
                }
            }

            return res;
        }
    }
}
