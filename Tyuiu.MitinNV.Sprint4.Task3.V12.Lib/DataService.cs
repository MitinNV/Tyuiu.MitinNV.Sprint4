using System.Net.WebSockets;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MitinNV.Sprint4.Task3.V12.Lib
{
    public class DataService : ISprint4Task3V12
    {
        public int Calculate(int[,] array)
        {
            int[] ints = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                ints[i] = array[i, 2];
            }

            return ints.Min();
        }
    }
}
