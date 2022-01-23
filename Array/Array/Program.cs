using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6];
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter array number {i + 1}:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int step;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        step = array[i];
                        array[i] = array[j];
                        array[j] = step;
                    }
                }
                Console.Write(array[i] + " ");
            }
            Console.Write(array[^1]);
        }
    }
}
