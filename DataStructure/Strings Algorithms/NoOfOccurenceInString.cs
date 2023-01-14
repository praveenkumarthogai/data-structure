using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DataStructure.Strings_Algorithms
{
    internal class NoOfOccurenceInString
    {
        //Step 1 : Enter the string
        //Step 2 : Enter the char to find its maximum occurence
        public void Pattern1()
        {
            Console.WriteLine("Enter the string");
            string input = Console.ReadLine();
            Console.WriteLine("Enter the character to find its position and  its no of occurence");
            char charInput = Char.Parse(Console.ReadLine());
            int inputLength = input.Length;
            int noofOccurence = 0;
            for (int i = 0; i <= inputLength - 1; i++)
            {
                if (charInput == input[i])
                {
                    noofOccurence++;
                    Console.WriteLine($"Found at Position {i}");
                }
            }

            Console.WriteLine($"Maximum no of Occurence {noofOccurence}");

        }


        //Find the Character which has maximum occurence
        public void Pattern2()
        {
            string x = "Praveen";
            int[] asciiArray = new int[255];


            for (int i = 0; i <= 254; i++)
            {
                asciiArray[i] = 0;
            }

            int j = 0;
            while (j <= x.Length - 1)
            {
                int asciiValue = (int)x[j];
                asciiArray[asciiValue]++;
                j++;
            }

            int max = 0;
            int position = 0;
            for (int i = 0; i < asciiArray.Length - 1; i++)
            {
                if (asciiArray[i] > max)
                {
                    max = asciiArray[i];
                    position = i;

                }
            }

            char character = (Char)position;
            Console.WriteLine($"{character} - {max}");
        }
    }
}