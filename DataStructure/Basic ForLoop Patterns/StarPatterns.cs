using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Basic_Start_Patterns
{
    internal class StarPatterns
    {
        public void Pattern1()
        {
            int n = 5;
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }


        public void Pattern2()
        {
            int n = 5;
            for (int i = n; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
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
                    Console.Write("*");
                }

                Console.WriteLine("\n");
            }
        }



        public void Pattern4()
        {
            int n = 5;

            for (int i = n; i >= 1; i--)
            {
                for (int k = n - i; k > 0; k--)
                {
                    Console.Write(" ");
                }

                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine("\n");
            }
        }

    }
}
