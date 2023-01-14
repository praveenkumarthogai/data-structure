using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class TestTest
    {
        // [1(0),2(1),3(2),4(3),5()4,6(5)]
        public void check()
        {


            List<int> x = new List<int>();
            x.Add(1);
            x.Add(2);
            x.Insert(0, 3); // insert 3 at zero index
            x.RemoveAt(1); // 1 will be removed

        }
    }
}
