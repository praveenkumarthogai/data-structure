using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class Test
    {


        public void Test1()
        {
            int[] x = new int[2] { 200, 300 };
            Test2(x);
            Test3(x);
        }



        public void Test2(int[] x)
        {
            x[0] = 100;
        }

        public void Test3(int[] x)
        {
            int r = x[0];
        }
    }
}
