using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int k = 0;
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for(int j = 0; j < array.Length / (array.GetUpperBound(0) + 1); j++)
                {
                    if (array[i, j] > k) 
                        k = array[i, j];
                }
                Console.WriteLine(k);
            }
        }
    }
}
