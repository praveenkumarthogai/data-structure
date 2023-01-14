using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class HeapSort
    {
        public void Main()
        {

            int s = 5;
            HeapSortAlgorithm obj = new HeapSortAlgorithm();
            obj.GetUnsortedArray();
            obj.PrintArray();

            for (int i = s / 2 - 1; i >= 0; i--)
            {
                obj.MinHeapify(i);
            }
            obj.HeapSort();
        }
    }
}
