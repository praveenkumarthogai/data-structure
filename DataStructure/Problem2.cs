using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class Problem2
    {

        public void RevereseArray()
        {
            var x = new int[5] { 1, 2, 3 ,4,5};


            for(int i=0;i<x.Length;i++)
            {
                Console.WriteLine(x[i]);
            }


            for(int i = x.Length-1;i >= 0; i--)
            {
                Console.WriteLine(x[i]);
            }

            Console.ReadKey();

        }

    }
}
