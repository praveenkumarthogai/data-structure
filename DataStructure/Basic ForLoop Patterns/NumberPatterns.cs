using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Basic_ForLoop_Patterns
{
    internal class NumberPatterns
    {
        public void Pattern1()
        {
            int n = 5;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{i}");
                }
                Console.Write("\n");
            }
        }


        public void Pattern2()
        {
            int n = 5;
            for (int i = 0; i <= n; i++)
            {
                for (int j = n - i; j >= 0; j--)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }
        }




        public void Pattern3()
        {
            int n = 5;
            for (int i = 0; i <= n; i++)
            {
                for (int k = n - i; k > 0; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }
        }



        public void Pattern4()
        {
            int n = 5;
            for (int i = n; i > 0; i--)
            {
                for (int k = n - i; k > 0; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(n - i);
                }
                Console.Write("\n");
            }

        }

    }
}
