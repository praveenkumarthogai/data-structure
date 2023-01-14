using System;

namespace DataStructure
{
    internal class InsertionAlgorithm
    {
        public void Main()
        {
            int[] x = new int[] { 20, 30, 10, 5 };
            InsertSortAlgorithm(x);
        }

        public void InsertSortAlgorithm(int[] array)
        {
            int j, key;

            for (int i = 1; i < array.Length; i++)
            {
                key = array[i];
                j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
