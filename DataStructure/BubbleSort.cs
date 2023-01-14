using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class BubbleSort
    {
        public void Main()
        {
            int[] x = new int[] { 4, 8, 3, 2, 1, 7 };
            Console.WriteLine("Before Sorting");
            Console.WriteLine("\n");
            for (int z = 0; z < x.Length; z++)
            {
                Console.Write(x[z]);
            }
            Console.WriteLine("\n");
            BubbleSortAlgorith(x, 0, 5);
        }

        public void BubbleSortAlgorith(int[] x, int startIndex, int EndIndex)
        {
            bool flag = false;
            int temp;
            for (int i = 0; i < EndIndex - 1; i++)
            {
                flag = false;
                for (int j = 0; j < EndIndex; j++)
                {
                    if (x[j] > x[j + 1])
                    {
                        temp = x[j];
                        x[j] = x[j + 1];
                        x[j + 1] = temp;
                        flag = true;
                    }
                }
                if (!flag)
                {
                    break;
                }
            }

            Console.WriteLine("Final Sorting");
            Console.WriteLine("\n");

            for (int z= 0; z < x.Length; z++)
            {
                Console.Write(x[z]);
            }
        }
    }
}
