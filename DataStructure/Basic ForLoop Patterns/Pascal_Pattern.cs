using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Basic_ForLoop_Patterns
{
    internal class Pascal_Pattern
    {
        public void Pattern1()
        {

        }


        public void Pattern2()
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                int x = 1;

                for (int k = n - i; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{x} ");
                    x = x * (i - j) / j;
                }
                Console.Write("\n");
            }
        }
    }
}
