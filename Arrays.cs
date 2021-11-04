﻿using System;
using System.Collections.Generic;

namespace Datastructures
{
    public class Arrays
    {
        /* print minimum  operation required to make all elements of an array equal */
        public int  _printMinArrayOps(int[] arr)
        {
            int arraySum, smallest,
            array_size = arr.Length;
            arraySum = 0;
            smallest = arr[0];

            for (int i = 0; i < array_size; i++)
            {
                /* If current element is smaller then update smallest */
                if (arr[i] < smallest)
                    smallest = arr[i];

                /*find array sum */
                arraySum += arr[i];
            }

            int minOperation = arraySum -array_size * smallest;

            /* Print min operation required */
            // Console.Write("Minimum Operation = " + minOperation);

            return minOperation;
        }


        public int LeetCodeMinOperations(int n)
        {
            int _sum = 0;
            for (int i = 0; i < n / 2; i++)
                _sum += n - (2 * i) - 1;
            return _sum;
        }

        /* Returns the product of max product subarray. it assumes that the given array always has a subarray
        with product more than 1 */
        public int _maxSubarrayPrdct(int[] arr)
        {

            int n = arr.Length; //length of array
            // max positive product ending at the current position
            int max_p_ending_here = 1;

            // min negative product ending at the current position
            int min_n_ending_here = 1;

            // Initialize overall max product
            int max_so_now = 0;
            int flag = 0;

            /* Traverse through the array. Following
            values are maintained after the ith iteration:
            max_p_ending_here is always 1 or some positive
            product ending with arr[i] min_n_ending_here is
            always 1 or some negative product ending
            with arr[i] */
            for (int i = 0; i < n; i++)
            {
                /* If this element is positive, update
                max_p_ending_here. Update min_n_ending_here
                only if min_ending_here is negative */
                if (arr[i] > 0)
                {
                    max_p_ending_here = max_p_ending_here * arr[i];
                    min_n_ending_here = min(min_n_ending_here * arr[i], 1);
                    flag = 1;
                }

                /* If this element is 0, then the maximum
                product cannot end here, make both
                max_p_ending_here and min_n_ending_here 0
                Assumption: Output is alway greater than or
                equal to 1. */
                else if (arr[i] == 0)
                {
                    max_p_ending_here = 1;
                    min_n_ending_here = 1;
                }

                /* If element is negative. This is tricky
                max_p_ending_here can either be 1 or positive.
                max_p_ending_here can either be 1 or negative.
                next min_ending_here will always be prev.
                max_ending_here * arr[i]
                next max_p_ending_here will be 1 if prev
                min_n_ending_here is 1, otherwise
                next max_p_ending_here will be
                prev min_n_ending_here * arr[i] */
                else
                {
                    int temp = max_p_ending_here;
                    max_p_ending_here = max(min_n_ending_here * arr[i], 1);
                    min_n_ending_here = temp * arr[i];
                }

                // update max_so_now, if needed
                if (max_so_now < max_p_ending_here)
                    max_so_now = max_p_ending_here;
            }

            if (flag == 0 && max_so_now == 0)
                return 0;

            return max_so_now;
        }

        // functions to get minimum of two integers
        int min(int x, int y)
        {
            return x < y ? x : y;
        }

        // Utility functions to get maximum of two integers
        int max(int x, int y)
        {
            return x > y ? x : y;
        }


        /* reverse integer array arr[]  from  start to end*/
        public void _reverseArray(int[] arr, int start, int end) //takes arr[], start and end positions
        {
            //Time complexity: O(n)
            int temp;

            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        /* prints out an array on a line */
        public void printArray(int[] arr, int size) //size of array
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }

        //reverse list of integer items
        public void _reverseList()
        {

            // create a List<T> of Integers
            List<int> list_a = new List<int>();

            // add elements to List
            for (int i = 1; i <= 5; i++)
            {
                list_a.Add(i);
            }

            Console.WriteLine("Elements Present in List:");

            // display the elements of List
            foreach (int k in list_a)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine(" ");

            Console.WriteLine("Reversed _lst: ");

            // using method Reverse()
            list_a.Reverse();

            // Displaying the elements of List
            foreach (int k in list_a)
            {
                Console.WriteLine(k);
            }

        }

        //reverse string list
        public void _reverseStringList()
        {
            // create a List<T> of strings
            List<string> list_s = new List<string>();

            // add elements to List
            list_s.Add("Shawn");
            list_s.Add("Mercy");
            list_s.Add("Gianna");
            list_s.Add("Clarke");

            Console.WriteLine("original _lst:");

            // display the elements of List
            foreach (string k in list_s)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine(" ");

            Console.WriteLine("reversed _lst: ");

            // using method Reverse()
            list_s.Reverse();

            // Displaying the elements of List
            foreach (string k in list_s)
            {
                Console.WriteLine(k);
            }
        }

        /**
         * Performs run-length encoding on a string.  If the encoded string
         * would be longer than the input, then the input string is returned.
         * To make decoding simple and unambiguous, streaks are limited to
         * 9 characters long; longer streaks are broken up.
         * 
         *  a) Pick the first character from the source string. 
            b) Append the picked character to the destination string. 
            c) Count the number of subsequent occurrences of the picked character and append the count to the destination string. 
            d) Pick the next character and repeat steps b) c) and d) if the end of the string is NOT reached.
        
         */
        public string _compressSting(string input)
        {
            if (input.Length < 3) return input;

            int n = input.Length; int i = 0; int o = 0;
            char[] output = new char[n + 1];
            output[o++] = input[0];
            output[o++] = '1';
            for (i = 1; i < n && o < n; i++)
            {
                if (input[i] == input[i - 1] && output[o - 1] != '9')
                {
                    // Continued streak
                    output[o - 1]++;
                }
                else
                {
                    // New streak
                    output[o++] = input[i];
                    output[o++] = '1';
                }
            }
            return (i == n && o < n) ? new string(output, 0, o) : input;
        }

        //palidromes 
        /*  1.Create a count array of alphabet size which is typically 256. Initialize all values of count array as 0.
            2.Traverse the given string and increment count of every character.
            3.Traverse the count array and if the count array has more than one odd values, return false. Otherwise, return true
         * /

        /* function to check whether characters of a string can form a palindrome */
        public  bool canFormPalindrome(string str)
        {
            //O(n) time using a count array.
            int NO_OF_CHARS = 256;

            // create a count array and initialize all values as 0
            int[] count = new int[NO_OF_CHARS];
            Array.Fill(count, 0);

            // For each character in input strings, increment count in the corresponding count array
            for (int i = 0; i < str.Length; i++)
                count[(int)(str[i])]++;

            // Count odd occurring characters
            int odd = 0;
            for (int i = 0; i < NO_OF_CHARS; i++)
            {
                if ((count[i] & 1) == 1)
                    odd++;

                if (odd > 1)
                    return false;
            }

            // return true if odd count is 0 or 1, can form a palidrome
            return true;
        }

        //check palidrome using list
        /* For a string to be palindrome all the characters should occur an EVEN number of times if the string is of even length
         *  and AT MOST one character can occur an odd number of times if the string length is odd. 
         * 
         * 
         * O(n) time using a list. 
           1. Create a character list.-to put all the characters of the string
           2. Traverse the given string.
           3. For every character in the string, remove the character if the list already contains else add to the list.
           4. If the string length is even the list is expected to be empty.
           5. Or if the string length is odd the list size is expected to be 1
           6. On the above two conditions (3) or (4) return true else return false.
         */

        public bool _canFormPalindrome(string str)
        {
            //time complexity : O(n) time using a list. 
            // create a new list
            List<char> _lst = new List<char>();

            // For each character in input strings, remove character if list contains
            // else add character to list
            for (int i = 0; i < str.Length; i++)
            {
                if (_lst.Contains(str[i]))
                    _lst.Remove((char)str[i]);
                else
                    _lst.Add(str[i]);
            }

            // if character length is even list is expected to be empty
            // or if character length is odd list size is expected to be 1

            // if string length is even
            if (str.Length % 2 == 0 && _lst.Count == 0 || (str.Length % 2 == 1 && _lst.Count == 1))
                return true; //string can form a palidrome


            // if string length is odd
            else
                return false; //string cannot form a palidrome
        }

        //rearrange a string to form a palidrome
    
        //URLify a string
        // Replaces spaces with %20  and returns new length of modified string.
        // It returns -1 if modified string cannot be stored in string array []
       public char[] _URLifyString(char[] str)
        {
            // Time Complexity: O(n), where n is the true length of the string.
            // Auxiliary Space: O(1), because  program is an in-place algorithm.
            // in-place algorithm updates input sequence through replacement or swapping of elements

            // maximum length of string after modifications.
            int MAX = 1000;

            // count spaces and find current length
            int space_count = 0, i = 0;
            for (i = 0; i < str.Length; i++)
                if (str[i] == ' ')
                    space_count++;

            // count spaces and find current length
            while (str[i - 1] == ' ')
            {
                space_count--;
                i--;
            }

            // Find new length.
            int new_length = i + space_count * 2;

            // New length must be smaller than length of string provided.
            if (new_length > MAX)
                return str;

            // Start filling character from end
            int index = new_length - 1;

            char[] new_str = str;
            str = new char[new_length];

            // Fill rest of the string from end
            for (int j = i - 1; j >= 0; j--)
            {

                // replace space with %20 
                if (new_str[j] == ' ')
                {
                    str[index] = '0';
                    str[index - 1] = '2';
                    str[index - 2] = '%';
                    index = index - 3;
                }
                else
                {
                    str[index] = new_str[j];
                    index--;
                }
            }
            return str;
        }


    }
}
