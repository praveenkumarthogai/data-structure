using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DataStructure.Strings_Algorithms
{
    internal class OppositeCase
    {
        public void ChangeOppositeCase()
        {
            string name = "PeruMAL";
            int length = name.Length;
            StringBuilder stringBuilder = new StringBuilder();

            //for (int i = 0; i <= name.Length - 1; i++)
            //{
            //    if (name[i] > 'a' && name[i] < 'z')
            //    {
            //        stringBuilder.Append(name[i] - 32);
            //    }
            //    else if (name[i] > 'A' && name[i] < 'Z')
            //    {
            //        stringBuilder.Append(name[i] + 32);
            //    }
            //};

            //A-Z (65 - 90)  | a-z (97 - 122)

            foreach (char x in name)
            {
                if (x >= 'a' && x <= 'z')
                {
                    stringBuilder.Append(x.ToString().ToUpper());
                }
                else if (x >= 'A' && x <= 'Z')
                {
                    stringBuilder.Append(x.ToString().ToLower());
                }
                else
                {
                    stringBuilder.Append(x);
                }
            }

            Console.WriteLine(stringBuilder);
        }

        public void ConvertASCIIToChar(int x)
        {
            Console.WriteLine(Convert.ToChar(x));
        }


        public void GetASCIIValue(char x)
        {
            string y = "";
            var result = Encoding.ASCII.GetBytes(y);
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }

            int asciiValue = (int)x;
        }


        //Find no of words in a camel case sequence 

        public void FindNoOfWordsInCamelCaseSequence()
        {
            string x = "praveenKumarPraveenKumar";
            int count = x.Length > 0 ? 1 : 0;
            for (int i = 0; i <= x.Length - 1; i++)
            {
                if (x[i] >= 65 && x[i] <= 90)
                {
                    count++;
                }
            }
            Console.Write($"No  of Words{count}");
        }

        //Print last character of each word in a string

        public void FindLastLetterofEachWordinastring()
        {
            string x = "Happy new Year";
            x = x + " ";

            List<char> list = new List<char>();
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == ' ')
                {
                    list.Add(x[i - 1]);
                }
            };

            foreach (var c in list)
            {
                Console.WriteLine(c);
            }
        }


        //Find First and Last of the string

        public void FindFirstAndLastLetteroftheString()
        {
            string x = "Happy New Year";

            List<char> list = new List<char>();
            for (int i = 0; i <= x.Length - 1; i++)
            {
                if (i == 0)
                {
                    list.Add(x[i]);
                }

                if (x[i] == ' ')
                {
                    list.Add(x[i - 1]);
                    list.Add(x[i + 1]);
                }

                if (i == x.Length - 1)
                {
                    list.Add(x[i]);
                }
            }

            foreach(char c in list)
            {
                Console.WriteLine(c);
            }
        }
    }
}
