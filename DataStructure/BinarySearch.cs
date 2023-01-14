using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Text;

namespace DataStructure
{
    internal class BinarySearch
    {
        public void Main()
        {
            string x = Console.ReadLine();
            string[] array = x.Split(' ');
            int[] srcArray = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                srcArray[i] = Int32.Parse(array[i]);
            }
            int position = SearchByBinarySearchAlgorithm(srcArray, 0, srcArray.Length - 1, 100);



            if (position == -1)
            {
                Console.WriteLine("Match Not Found");
            }
            else
            {
                Console.WriteLine($"Match found at Position -{position}");
            }
        }

        public int SearchByBinarySearchAlgorithm(int[] srcArray, int left, int right, int value)
        {
            while (left <= right)
            {
                int midIndex = left + (right - left) / 2;

                if (srcArray[midIndex] == value)
                {
                    return midIndex;
                }
                else if (srcArray[midIndex] < value) 
                {
                    left = midIndex + 1;
                }
                else
                {
                    right = midIndex - 1;
                }
            }
            return -1;
        }
    }
}