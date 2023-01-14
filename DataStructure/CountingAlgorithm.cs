using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class CountingAlgorithm
    {
        public void CountingSort(int[] input_array, int s, int r)
        {
            int[] output_array = new int[s];
            int[] count_array = new int[r];

            //initialize all elements to 0 in count array
            for (int i = 0; i < r; i++)
            {
                count_array[i] = 0;
            }

            //to take a count of all elements in the input array
            for (int i = 0; i < s; i++)
            {
                ++count_array[input_array[i]];
            }

            //cumalative count of count array to get the positions of elements
            //to be stored in the output array
            for (int i = 1; i < r; i++)
            {
                count_array[i] = count_array[i] + count_array[i - 1];
            }

            for (int i = 0; i < s; i++)
            {
                output_array[--count_array[input_array[i]]] = input_array[i];
            }

            //print the final sorted output

            for (int i = 0; i < output_array.Length; i++)
            {
                Console.WriteLine(output_array[i]);
            }

        }


        public void Main()
        {
            int[] x = new int[5] { 5, 8, 7, 6, 3 };
            CountingSort(x, 5, 9);
        }

    }
}
