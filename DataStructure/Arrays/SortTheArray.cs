using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure.Arrays
{
    internal class SortTheArray
    {
        //using concat & sort default methods in c#
        public void UsingCSharpMethods()
        {
            int[] x1 = new int[5] { 1, 3, 5, 9, 2 };
            int[] x2 = new int[5] { 8, 6, 7, 0, 0 };

            var x3 = x1.Concat(x2).ToArray();

            Array.Sort(x3);

            foreach (int i in x3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
