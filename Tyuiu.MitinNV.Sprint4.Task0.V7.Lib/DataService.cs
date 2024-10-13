using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MitinNV.Sprint4.Task0.V7.Lib
{
    public class DataService : ISprint4Task0V7
    {
        public int GetMultOddArrEl(int[] array)
        {
            int res = 1;
            foreach (var item in  array)
            {
                if (item%2 == 1)
                {
                    res *= item;
                }
            }

            return res;
        }
    }
}
