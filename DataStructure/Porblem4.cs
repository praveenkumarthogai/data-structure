using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class Problem4
    {
        public void InsertArrayAtPosition()
        {
            int[] x = new int[] { 1, 23, 4 };

            Console.WriteLine("Enter the Value");
            var input = Int32.Parse(Console.ReadLine());
            var position = Int32.Parse(Console.ReadLine());

            //Print the initia values

            for(int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }



            int[] newX = new int[x.Length + 1];
            for(int i = 0; i < newX.Length; i++)
            {
                if(i < position)
                {
                    newX[i] = x[i];
                }
                else if (i == position)
                {
                    newX[i] = input;
                }
                else
                {
                    newX[i] = x[i - 1];
                }
            }

            Console.WriteLine("Iteration of values after Insertion");

            for (int i = 0; i < newX.Length; i++)
            {
                Console.WriteLine(newX[i]);
            }
        }
    }
}
