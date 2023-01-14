using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class Problem3
    {
        public void FindDuplicateArray()
        {
            var x = new int[5] { 1, 2, 3, 1, 2 };
            var dic = new Dictionary<int, int>();
            var duplicate = new List<int>();

            for (int i = 0; i < x.Length; i++)
            {
                if (dic.ContainsKey(x[i]))
                {
                    duplicate.Add(x[i]);
                }
                else
                {
                    dic.Add(x[i], i);
                }
            }

            for (int i = 0; i < duplicate.Count; i++)
            {
                Console.WriteLine(duplicate[i]);
            }
        }
    }
}
