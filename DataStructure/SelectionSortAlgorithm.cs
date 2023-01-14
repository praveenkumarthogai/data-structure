using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class SelectionSortAlgorithm
    {
        public void Main()
        {
            int[] x = new int[] { 200, 100, 500, 250, 400 };
            Console.WriteLine("Array Iterated before selection sort");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }

            SelectionSort(x, x.Length);
        }

        public void SelectionSort(int[] x, int length)
        {
            Console.WriteLine("Selection Sort Algorithm started");

            for (int i = 0; i < length - 1; i++)
            {
                int assumeMinValueIndex = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (x[j] < x[assumeMinValueIndex])
                    {
                        assumeMinValueIndex = j;
                    }
                }

                //Swap operation
                if (assumeMinValueIndex != i)
                {
                    int swapValuetoi = x[assumeMinValueIndex];
                    int swapValueToAssumeMinValueIndex = x[i];

                    x[i] = swapValuetoi;
                    x[assumeMinValueIndex] = swapValueToAssumeMinValueIndex;
                }
            }

            Console.WriteLine("Array Iterated after selection sort");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(x[i]);
            }
            Console.ReadKey();
        }
    }
}
