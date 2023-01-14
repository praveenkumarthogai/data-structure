using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Strings_Algorithms
{
    internal class ReverseString
    {
        //Reverse the string using for loop
        public void Pattern1()
        {
            string x = "Check";
            for (int i = x.Length - 1; i >= 0; i--)
            {
                Console.Write(x[i]);
            }
        }


        //Reverse the string using swap 
        public void Pattern2()
        {
            string x = "Check";
            int i = 0;
            int n = x.Length - 1;
            while (i <= n)
            {
                int temp1 = x[i];
                int temp2 = x[n];
                i = i + 1;
                n = n - 1;
            }
        }
    }
}