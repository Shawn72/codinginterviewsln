using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Datastructures
{
    class Program
    {
        static void Main(string[] args)
        {

            //  string k = " mbuvi      shawn ";
            //  Console.WriteLine("Reversed: "+ _ReverseWord(k));
            //  _Stack();
            //_LinkedList();

            // int[] arr = { 1, -4, -3, 0, 9, -8, -2 };

            //Console.WriteLine("Maximum Sub array product is: " + _maxSubarrayPrdct(arr));

            //call reverse array code
            // _reverseIntArrCode(arr);

            //call reverse list -int/string
            //  _reverseList();
            // _reverseStringList();

            ////////Lists
            //_LinkedListOps();
            // _LinkedListWHashmap();
            // Console.WriteLine( "compressed: "+_compressSting("aaabbbrrrruuuuu") );
            // Console.WriteLine("Can form a palidrome?: " + _canFormPalindrome("cooc") );
            // Console.WriteLine("palidrome: " + _getPalindrome("mdaam"));
            //Console.WriteLine("UrLified string: " + URLify_String("http://ninjax company ltd.com"));

            _GetKthElementofLinkedList(2); //put n position


            //below code should come at the bottom, make cmd not disappear
            Console.ReadLine();
        }

        static string URLify_String(string strn) {

            char[] str = strn.ToCharArray();
            string urlfied = "";

            // Prints the replaced string
            str = _URLifyString(str);


            for (int i = 0; i < str.Length; i++) {
                urlfied += str[i];
            }
            return urlfied;
        }

        static void _reverseIntArrCode(int[] arr)
        {
            Console.Write("original array is \n");
            printArray(arr, 7);
            //reverse array
            _reverseArray(arr, 0, 6);
            //then print after reverse
            Console.Write("reversed array is \n");
            printArray(arr, 7);
        }

        //reverse string[] array
        public static string _ReverseStr(string str)
        {

            char[] stringArray = str.ToCharArray();
            Array.Reverse(stringArray);
            string reversedString = new string(stringArray);

            return reversedString;
        }

        public static string _ReverseWord(string str)
        {
            //Time Complexity: O(len(str))
            //trim answer first, from both sides incase str has spaces on both ends
            str = str.Trim();
            int i = str.Length - 1;
            int start, end = i + 1;
            string answer = "";

            while (i >= 0)
            {
                if (str[i] == ' ')
                {
                    start = i + 1;
                    while (start != end)
                        answer += str[start++];

                    answer += ' ';

                    end = i;
                }
                i--;
            }

            start = 0;
            while (start != end)
                answer += str[start++];

            //regex to replace extra spaces in the reversed string,  also extra white space
            Regex cutter = new Regex(@"\s\s+", RegexOptions.Compiled);

            answer = cutter.Replace(str, " ");

            return answer;
        }

        public static void _Stack()
        {

            // create a stack using inbuilt Stack class
            Stack _stack = new Stack();
            // add elements in the Stack usin Push method           
            _stack.Push("Shawn");
            _stack.Push("Mercy");
            _stack.Push("Nina");
            _stack.Push("Clarke");

            // access the elements of stack using foreach loop
            foreach (var elem in _stack)
            {
                Console.WriteLine("element: " + elem);
            }

            _stack.Pop(); //remove element at the top of stack

            // printt elements after Pop()
            foreach (var elem in _stack)
            {
                Console.WriteLine("after pop: " + elem);
            }
        }

        public static void _LinkedList()
        {


            // create a linkedlist LinkedList class , of type string
            LinkedList<string> _list = new LinkedList<string>();

            // add elements in the LinkedList using AddLast() method
            _list.AddLast("Shawn");
            _list.AddLast("Mercy");
            _list.AddLast("Clarke");
            _list.AddLast("Mutheu");

            Console.WriteLine("My family: ");

            // access the elements of LinkedList Using foreach loop
            foreach (string str in _list)
            {
                Console.WriteLine(str);
            }
        }

        /* Returns the product of max product subarray. it assumes that the given array always has a subarray
        with product more than 1 */
        public static int _maxSubarrayPrdct(int[] arr)
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
        // Utility functions to get minimum of two integers
        static int min(int x, int y)
        {
            return x < y ? x : y;
        }

        // Utility functions to get maximum of two integers
        static int max(int x, int y)
        {
            return x > y ? x : y;
        }

        //singly linkedlist: create the node
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        public class SingleLinkedList
        {
            internal Node head;

            //insert data at the front of the list
            internal void InsertFront(SingleLinkedList singlyList, int new_data)
            {
                Node new_node = new Node(new_data);
                new_node.next = singlyList.head;
                singlyList.head = new_node;
            }

            //insert last
            internal void InsertLast(SingleLinkedList singlyList, int new_data)
            {
                Node new_node = new Node(new_data);
                if (singlyList.head == null)
                {
                    singlyList.head = new_node;
                    return;
                }
                Node lastNode = GetLastNode(singlyList);
                lastNode.next = new_node;
            }

            internal Node GetLastNode(SingleLinkedList singlyList)
            {
                Node temp = singlyList.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                return temp;
            }
            //delete node by key
            internal void DeleteNodebyKey(SingleLinkedList singlyList, int key)
            {
                Node temp = singlyList.head;
                Node prev = null;
                if (temp != null && temp.data == key)
                {
                    singlyList.head = temp.next;
                    return;
                }
                while (temp != null && temp.data != key)
                {
                    prev = temp;
                    temp = temp.next;
                }
                if (temp == null)
                {
                    return;
                }
                prev.next = temp.next;
            }

            //remove duplicates from a sorted linked list
            public void _removeDuplicates()
            {
                /*ref to head*/
                Node current = head;

                /* Pointer to store the next pointer of a node to be deleted*/
                Node next_next;

                /* do nothing if the list is empty */
                if (head == null)
                    return;

                /* Traverse list till the last node */
                while (current.next != null)
                {

                    /*compare current node with the next node */
                    if (current.data == current.next.data)
                    {
                        next_next = current.next.next;
                        current.next = null;
                        current.next = next_next;
                    }
                    else // advance if no deletion
                        current = current.next;
                }
            }
            
            /* insert a new Node at front of the list. */
            public void _pushtoNode(int new_data)
            {
                /* Allocate the Node and Put in the data to the node*/
                Node new_node = new Node(new_data);

                /* Make next of new Node as head */
                new_node.next = head;

                /* Move the head to point to new Node */
                head = new_node;
            }

            /* print linked list */
            public void _printList()
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
            
            // remove duplicates from an unsorted linked list
            public void removeDuplicateFromList(Node head)
            {

                // Hash to store already seen values
                HashSet<int> hs = new HashSet<int>();

                // Pick elements one by one
                Node current = head;
                Node prev = null;
                while (current != null)
                {
                    int curval = current.data;

                    // If current value is seen before
                    if (hs.Contains(curval))
                    {
                        prev.next = current.next;
                    }
                    else
                    {
                        hs.Add(curval);
                        prev = current;
                    }
                    current = current.next;
                }
            }

            // print nodes in a given linked list
            public void _printNode(Node head)
            {
                while (head != null)
                {
                    Console.Write(head.data + " ");
                    head = head.next;
                }
            }

            // find kth element
            /* get the nth node from the last of a linked list */
            public void _printKthFromLast(int n)
            {
                //Time Complexity: O(n) where n is the length of linked list. 

                int len = 0;
                Node temp = head;

                // a) count the number of nodes in Linked List 
                while (temp != null)
                {
                    temp = temp.next;
                    len++;
                }

                // check if value of n is not more than length of the linked list 
                if (len < n) { 
                  Console.WriteLine("position "+ n +" not available in the list");
                    return;
                }

                temp = head;

                // b) get the (len-n+1)th node from the beginning 
                for (int i = 1; i < len - n + 1; i++)
                    temp = temp.next;

                Console.WriteLine(temp.data);
            }
        }

        static void _GetKthElementofLinkedList(int n) {
            SingleLinkedList llist = new SingleLinkedList();
            llist._pushtoNode(25);
            llist._pushtoNode(40);
            llist._pushtoNode(18);
            llist._pushtoNode(32);

            //print list
            Console.WriteLine("Elements list:");
            llist._printList();
            Console.WriteLine("\n");
            Console.WriteLine( "position "+n+" from last: " );          
            llist._printKthFromLast(n);
            ;

        }

        static void _LinkedListOps()
        {

            //Time Complexity: O(n) where n is the number of nodes in the given linked list.

            SingleLinkedList _list = new SingleLinkedList();
            _list._pushtoNode(30);
            _list._pushtoNode(26);
            _list._pushtoNode(26);
            _list._pushtoNode(50);
            _list._pushtoNode(40);
            _list._pushtoNode(40);

            Console.WriteLine("List before removing duplicates");
            _list._printList();
            Console.WriteLine(" \n");
            _list._removeDuplicates();
            Console.WriteLine("List after removing duplicates");
            _list._printList();
        }

        static void _LinkedListWHashmap()
        {

            //Time Complexity: O(n) on average (assuming that hash table access time is O(1) on average).

            SingleLinkedList _list = new SingleLinkedList();
            Node _start = new Node(70);
            _start.next = new Node(40);
            _start.next.next = new Node(60);
            _start.next.next.next = new Node(60);
            _start.next.next.next.next = new Node(40);

            Console.WriteLine("List before removing duplicates \n");
            _list._printNode(_start);
            Console.WriteLine(" \n");
            _list.removeDuplicateFromList(_start);
            Console.WriteLine("List after removing duplicates \n");
            _list._printNode(_start);
        }
        
        /* reverse integer array arr[]  from  start to end*/
        static void _reverseArray(int[] arr, int start, int end) //takes arr[], start and end positions
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
        static void printArray(int[] arr, int size) //size of array
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }

        //reverse list of integer items
        static void _reverseList()
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
        static void _reverseStringList()
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
        public static string _compressSting(string input)
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
        static bool canFormPalindrome(string str)
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

        static bool _canFormPalindrome(string str)
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
        public static string _getPalindrome(string str)
        {

            // Store counts of characters
            Hashtable ht = new Hashtable();

            //initialize keys
            ICollection myKey = ht.Keys;
            int nKey = 0;

            //add characters to the hashtable
            foreach (char ch in str.ToCharArray())
            {
                nKey++;
                ht.Add(nKey, ch);

                if (ht.ContainsKey(nKey))
                {
                    ht.Add(ht[nKey + 1], ch);
                }
                else
                {
                    ht.Add(1, ch);
                }
            }
            //get keys collection
            foreach (int k in myKey)
            {
                Console.WriteLine(ht[k]);
            }


            /* Find the number of odd elements.
            Takes O(n) */
            int oddCount = 0;
            char oddChar = (char)0;

            foreach (int val in myKey)
            {
                if (val % 2 != 0)
                {
                    oddCount++;
                    oddChar = (char)val;
                }
            }

            /* odd_cnt = 1 only if the length of
            str is odd */
            if (oddCount > 1 || oddCount == 1 &&
                str.Length % 2 == 0)
            {
                return "NO PALINDROME";
            }

            /* Generate first half of palindrome */
            string firstHalf = "", lastHalf = "";
            foreach (int entry in myKey)
            {

                // Build a string of floor(count/2)
                // occurrences of current character
                string ss = "";
                for (int i = 0; i < entry / 2; i++)
                {
                    ss += entry;
                }

                // Attach the built string to end of
                // and begin of second half
                firstHalf = firstHalf + ss;
                lastHalf = ss + lastHalf;
            }

            // Insert odd character if there
            // is any
            return (oddCount == 1) ? (firstHalf + oddChar + lastHalf) : (firstHalf + lastHalf);
        }

        //URLify a string
        // Replaces spaces with %20  and returns new length of modified string.
        // It returns -1 if modified string cannot be stored in string array []
        static char[] _URLifyString(char[] str)
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
