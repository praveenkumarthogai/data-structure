using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Strings_Algorithms
{
    internal class Panagram
    {

        public void CheckPanagram()
        {
            //string x = "Hello Praveen";
            string x = "The quick brown fox jumps over the lazy dog";
            int count = 0;
            x = x.ToLower();
            List<char> missingLetters = new List<char>();
            for (int i = 0; i <= x.Length - 1; i++)
            {
                if ((x[i] >= 'a' && x[i] <= 'z') || x[i]== ' ')
                {

                }
                else
                {
                    missingLetters.Add(x[i]);
                    count++;
                }
            }

            if (count > 0)
            {
                Console.WriteLine("This is not pangram");
            }
            else
            {
                Console.WriteLine("This is Pangram");
            }
        }
    }
}
