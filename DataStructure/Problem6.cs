using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class Problem6
    {

        public void SearchThePosition()
        {
            int[] x = new int[] { 100, 200, 300 };

            int value = Int32.Parse(Console.ReadLine());


            for(int i = 0; i < x.Length; i++)
            {
                if (x[i] == value)
                {
                    Console.WriteLine($"The given value is present at the position -  {i + 1}");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
