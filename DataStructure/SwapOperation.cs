using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class SwapOperation
    {
        public void SwapMethod(int n1, int n2)
        {
            int temp;
            temp = n1;
            n1 = n2;
            n2 = temp;

            Console.WriteLine("After swaping n1 - {0} , n2 - {1}", n1, n2);
            Console.WriteLine("Enter any key to exist");
            Console.ReadKey();
        }


    }
}
