using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class Problem1
    {
        public void Main()
        {
            Console.WriteLine("Enter Numbers Separated by comma");
            string input = Console.ReadLine();
            var x = input.Split(",");
            List<int> nums = new List<int>();
            foreach (string s in x)
            {
                if (Int32.TryParse(s, out int val))
                {
                    nums.Add(val);
                }
            }

            int minValue = FindMinimumNumber(nums);
            Console.WriteLine($" Minimum Value in the Array is  {minValue}");
            Console.ReadKey();
        }

        public int FindMinimumNumber(List<int> nums)
        {
            int minValue = nums[0];


            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] < minValue)
                {
                    minValue = nums[i];
                }
            }

            return minValue;

        }
    }
}
