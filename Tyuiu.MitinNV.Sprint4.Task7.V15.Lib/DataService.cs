using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MitinNV.Sprint4.Task7.V15.Lib
{
    public class DataService : ISprint4Task7V15
    {
        public int Calculate(int n, int m, string value)
        {
            int res = 0;
            var matrix = new int[n, m];
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Convert.ToInt32(value[counter]);
                    counter++;
                }
            }

            foreach (var item in matrix)
            {
                if (item%2 == 1)
                {
                    res++;
                }
            }
            return res;
        }
    }
}
