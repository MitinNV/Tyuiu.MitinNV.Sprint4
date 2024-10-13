using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MitinNV.Sprint4.Task5.V20.Lib
{
    public class DataService : ISprint4Task5V20
    {
        public int Calculate(int[,] matrix)
        {
            int res = 0;
            foreach (var item in matrix)
            {
                if (item > 0)
                {
                    res += item;
                }
            }

            return res;
        }
    }
}
