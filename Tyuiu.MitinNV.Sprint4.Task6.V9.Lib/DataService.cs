using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MitinNV.Sprint4.Task6.V9.Lib
{
    public class DataService : ISprint4Task6V9
    {
        public int Calculate(string[] array)
        {
            int res = 0;
            foreach (var item in array)
            {
                if (item.Length < 7)
                {
                    res++;
                }
            }

            return res;
        }
    }
}
