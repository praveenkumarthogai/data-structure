using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    internal class SlidingWindow_Using_Dequeue
    {
        //Steps to be followed
        //Create a dequeue list
        //Insert only index //Each iteration should have three elements only
        //If next index value is greater, then remove the index and insert the index which  has greater value
        //If next index value is small then insert the index  next right position 
        //when moving for next set of three elements (next window)
        //follow the conditions
        //*)pop the index value *) remove all the index which is not part of next window

        //time complexity => O(n)
        //space complexity => O(k)

        /// <summary>
        /// code was submitted by Jianmin Chen August 2015
        /// Time complexity: O(N), N is is the length of the array
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] MaxSlidingWindow()  //Using Linked List
        {
            var nums = new int[] { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;

            int len = nums.Length;
            int maxArrayLen = len - k + 1;
            int[] ans = new int[maxArrayLen];

            LinkedList<int> q = new LinkedList<int>();

            // Queue stores indices of array, and 
            // values are in decreasing order.
            // So, the first node in queue is the max in window
            for (int i = 0; i < len; i++)
            {
                // 1. remove element from head until first number within window
                if (q.Count > 0 && q.First.Value + k <= i)
                {
                    q.RemoveFirst();
                }


                // 2. before inserting i into queue, remove from the tail of the
                // queue indices with smaller value they array[i]
                while (q.Count > 0 && nums[q.Last.Value] <= nums[i])
                {
                    q.RemoveLast();
                }

                q.AddLast(i);

                // 3. set the max value in the window (always the top number in
                // queue)
                int index = i + 1 - k;
                if (index >= 0)
                {
                    ans[index] = nums[q.First.Value];
                }

            }


            //Printing the output

            for (int i = 0; i < ans.Length; i++)
            {
                Console.WriteLine(ans[i]);
            }


            return ans;
        }

        //NAIVE OR BRUT FORCE ALGORITHM
        //| SLIDING WINDOW | Time Complexity => O(n-k+1*K) => O(n * k)

        public void SlidingWindow_Brutforce()
        {
            int k = 3;
            int[] arr = new int[5] { 40, 50, 60, 70, 80 };

            int n = arr.Length;

            for (int i = 0; i <= n - k; i++)
            {
                int max = arr[i];

                for (int j = 0; j < k; j++)
                {
                    if (arr[j + i] > max)
                    {
                        max = arr[j + i];
                    }
                }
                Console.WriteLine(max);
            }
        }


        //using List 

        void SlidingWindowMax(int[] arr, int N, int K)
        {

            // Create a Double Ended Queue, Qi that
            // will store indexes of array elements
            // The queue will store indexes of useful
            // elements in every window and it will
            // maintain decreasing order of values
            // from front to rear in Qi, i.e.,
            // arr[Qi.front[]] to arr[Qi.rear()]
            // are sorted in decreasing order
            List<int> Qi = new List<int>();

            /* Process first K (or first window)
            elements of array */
            int i;
            for (i = 0; i < K; ++i)
            {
                // For every element, the previous
                // smaller elements are useless so
                // remove them from Qi
                while (Qi.Count != 0
                       && arr[i] >= arr[Qi[Qi.Count - 1]])

                    // Remove from rear
                    Qi.RemoveAt(Qi.Count - 1);

                // Add new element at rear of queue
                Qi.Insert(Qi.Count, i);
            }

            // Process rest of the elements,
            // i.e., from arr[k] to arr[n-1]
            for (; i < N; ++i)
            {
                // The element at the front of
                // the queue is the largest element of
                // previous window, so print it
                Console.Write(arr[Qi[0]] + " ");

                // Remove the elements which are
                // out of this window
                while ((Qi.Count != 0) && Qi[0] <= i - K)
                    Qi.RemoveAt(0);

                // Remove all elements smaller
                // than the currently
                // being added element (remove
                // useless elements)
                while ((Qi.Count != 0)
                       && arr[i] >= arr[Qi[Qi.Count - 1]])
                    Qi.RemoveAt(Qi.Count - 1);

                // Add current element at the rear of Qi
                Qi.Insert(Qi.Count, i);
            }

            // Print the maximum element of last window
            Console.Write(arr[Qi[0]]);
        }

    }
}
