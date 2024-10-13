using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MitinNV.Sprint4.Task4.V23.Lib
{
    public class DataService : ISprint4Task4V23
    {
        public int Calculate(int[,] matrix)
        {
            int res = 0;

            foreach (var item in matrix)
            {
                if (item%2 == 1)
                {
                    res += item;
                }
            }

            return res;
        }
    }
}
