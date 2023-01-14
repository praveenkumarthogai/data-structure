using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class HeapSortAlgorithm
    {
        int[] xArray;
        int capacity;
        int heap_size;
        public HeapSortAlgorithm()
        {
            xArray = new int[] { 2, 7, 8, 1, 0 };
            capacity = 5;
            heap_size = 5;
        }

        public void PrintArray()
        {
            for (int i = 0; i < heap_size; i++)
            {
                Console.WriteLine(xArray[i]);
            }
        }

        public int Parent(int i)
        {
            return (i - 1) / 2;
        }

        public int Left(int i)
        {
            return (2 * i + 1);
        }

        public int Right(int i)
        {
            return (2 * i + 2);
        }

        public int GetMin()
        {
            return xArray[0];
        }

        public void GetUnsortedArray()
        {
            for (int i = 0; i < capacity; i++)
            {

            }
        }

        public void HeapSort()
        {
            int[] temp = new int[5];
            for (int j = 0; j < capacity; j++)
            {
                temp[j] = ExtractMin();
                Console.WriteLine(temp[j]);
            }
        }

        //Method to remove minimum element or root element from min heap
        public int ExtractMin()
        {
            if (heap_size <= 0)
            {
                return int.MaxValue;
            }
            if (heap_size == 1)
            {
                heap_size--;
                return xArray[0];
            }

            //store the minimum value and remove it from heap

            int root = xArray[0];
            xArray[0] = xArray[heap_size - 1];
            heap_size--;
            MinHeapify(0);
            //Print Array();
            return root;
        }

        public void MinHeapify(int i)
        {
            int l = Left(i);

            int r = Right(i);

            int smallest = i;

            if (l < heap_size && xArray[l] < xArray[i])
            {
                smallest = l;
            }

            if (r < heap_size && xArray[r] < xArray[smallest])
            {
                smallest = r;
            }

            if (smallest != i)
            {
                int temp1 = xArray[i];
                int temp2 = xArray[smallest];

                xArray[i] = temp2;
                xArray[smallest] = temp1;
                MinHeapify(smallest);
            }
        }
    }
}
