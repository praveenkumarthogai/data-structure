using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class MergeSortAlgorithm
    {
        public void Merge(ref int[] arr, int l, int m, int r)
        {
            int i = l; //starting index for left subarray
            int j = m + 1; // starting index for right subarray
            int k = l; //starting index for temporary
            int[] temp = new int[5]; //temporary

            while (i <= m && j <= r)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k] = arr[i]; //arr[i] is smaller than  arr[j]
                    i++;
                    k++;
                }
                else
                {
                    temp[k] = arr[j]; //arr[j] is smaller than arr[i]
                    j++;
                    k++;
                }
            }
            while (i <= m)
            {
                temp[k] = arr[i]; // copying all elements from left subarray to temp as it is
                i++;
                k++;
            }
            while (j <= r)
            {
                temp[k] = arr[i];  // copying all elements from left subarray to temp as it is
                j++;
                k++;
            }

            for (int s = 0; s < 5; s++)
            {
                arr[s] = temp[s];
            }

        }


        public void MergeSort(ref int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;
                MergeSort(ref arr, l, m);
                MergeSort(ref arr, m + 1, r);
                Merge(ref arr, l, m, r);
            }

            
        }

        public void Main()
        {
            int[] x = new int[5] { 33, 99, 66, 55, 88 };
            MergeSort(ref x, 0, 4);
            for (int i = 0; i < x.Length - 1; i++)
            {
                Console.WriteLine(x[i]);
            }
        }
    }


}
