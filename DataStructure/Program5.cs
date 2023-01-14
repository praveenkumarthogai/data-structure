using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class Program5
    {
        public void DeleteArray()
        {
            int[] x = new int[] { 100, 200, 300, 400, 500, 600 };

            //Print the initial values and index positions
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"{x[i]} - Position at {i} ");
            }

            int intialLength = x.Length;

            int position = Int32.Parse(Console.ReadLine());
            int j = position;
            while (j < intialLength)
            {
                x[j-1] = x[j];
                j++;
            }

            for (int i = 0; i < x.Length - 1; i++)
            {
                Console.WriteLine("Printing the Numbers after deletion");
                Console.WriteLine($"{x[i]}");
            }
        }
    }
}
