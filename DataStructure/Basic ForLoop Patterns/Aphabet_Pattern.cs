using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Basic_ForLoop_Patterns
{
    internal class Aphabet_Pattern
    {
        public void Pattern1()
        {
            int n = 5;
            for(int i = 0; i <= n; i++)
            {
                char x = 'a';
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(x++);
                }
                Console.Write("\n");
            }
        }

        public void Pattern2()
        {
            int n = 5;
            char x = 'a';
            for (int i = 0; i <= n; i++)
            {
               
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(x);
                }
                x++;
                Console.Write("\n");
            }
        }


        public void Pattern3()
        {
            int n = 5;
            char x = 'a';
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(x);
                    x++;
                }
                
                Console.Write("\n");
            }
        }
    }
}
