using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class QuickSort
    {
        public void Main()
        {
            Console.WriteLine("quick start Process Started");
            int[] x = new int[] { 7, 9, 3, 2, 6 };
            
            QuickSortAlgorithm(x, 0, 4);
        }

        public void QuickSortAlgorithm(int[] x, int startIndex, int endIndex)
        {
            if(startIndex < endIndex)
            {
                int p = Partition(x, startIndex, endIndex);
                QuickSortAlgorithm(x, startIndex, (p - 1));
                QuickSortAlgorithm(x, (p + 1), endIndex);
            }

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }

            Console.WriteLine("QuickSort is Completed");
            Console.ReadKey();
        }

        private int Partition(int[] x, int startIndex, int endIndex)
        {
            int pivotValue = x[endIndex];
            int pivotIndex = startIndex;

            for (int i = startIndex; i <= (endIndex - 1); i++)
            {
                if (x[i] <= pivotValue)
                {
                    int num1, num2;
                    num1 = x[i];
                    num2 = x[pivotIndex];

                    x[i] = num2;
                    x[pivotIndex] = num1;
                    pivotIndex++;
                }
            }

            int num3, num4;
            num3 = x[endIndex];
            num4 = x[pivotIndex];

            x[endIndex] = num4;
            x[pivotIndex] = num3;

            return pivotIndex;
        }
    }
}
