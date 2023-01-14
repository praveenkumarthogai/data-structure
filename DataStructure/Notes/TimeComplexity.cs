using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Notes
{
    internal class TimeComplexity
    {
        //Time Complexity is analysed for 
        //*)Very Large Input Size
        //*)Worst Case Scenario
        //Polynomial
        //T(n) = 2n2 + 3n + 1 = O(n2);
        //Drop lower order terms i.e 3n + 1 
        //Drop all the constant multipliers i.e 3

        //1)Loop
        //for(i=1;i<n;i++){}  => cn => O(n)

        //2)Nested Loop => O(n2)
        //for(i=1;i<n;i++){ for(j=1;j<=n;j++){x = y + z   }

        //3)sequential Statements

        // a= a+b; c1 constant time
        // for loop c2n
        //for loop c3n

        //=>c1+c2n+c3n => O(n)
         
        //4)If else statement
        //if(condition)
        //{
                 //O(n)
        //}
        //el se
        //{
                //O(n2)
        //}

        //overall O(n2)

        //Order of Time complexity from best to worst
        //O(1) < 0(logn) < O(n) < O(n log n) < O(n^c) < O(n!)  => ! means exponential


    }
}
