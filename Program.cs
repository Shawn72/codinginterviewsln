using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static Datastructures.ListsNodeTrees;

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
            // _GetKthElementofLinkedList(2); //put n position

            //rotate matrix
            //matrix to compare to target rotated matrix
            int[][] imgmat = new int[][] {
                            new int[] { 1, 2, 3, 4, 5 },
                            new int[] { 6, 7, 8, 9, 10 },
                            new int[] { 11, 12, 13, 14, 15 },
                            new int[] { 16, 17, 18, 19, 20 },
                            new int[] { 21, 22, 23, 24, 25 } };

            //target matrix to compare with
            int[][] imgtarget = new int[][] {
                            new int[] { 21, 16, 11, 6 ,1 },
                            new int[] { 22, 17 ,12 ,7, 2},
                            new int[] { 23, 18 ,13 ,8 ,3 },
                            new int[] { 24 ,19 ,14 ,9, 4 },
                            new int[] { 25 ,20 ,15, 10, 5} };

            // _matrixRotate();
            // _rotateImgDriver(imgmat);

            // checkRotation(img, img2);

            //graphs
            // _GraphCanBeConnected();
            //  BinarySearchTree();
            //  LinkedListToBST();
            _checkBSTHeightBalance();

            //below code should come at the bottom, make cmd not disappear
            Console.ReadLine();
        }

        static void _checkBSTHeightBalance()
        {
            //head: used as root
            //_pushtoNode pushes to head, _pushtLnkNode pushes to lhead
            NodesAndLinkedLists nList = new NodesAndLinkedLists();
            /* create a sorted linked list
            7->6->5->4->3->2->1 */
            nList.pushLnkNode(7);
            nList.pushLnkNode(6);
            nList.pushLnkNode(5);
            nList.pushLnkNode(4);
            nList.pushLnkNode(3);
            nList.pushLnkNode(2);
            nList.pushLnkNode(1);

            Console.WriteLine("Linked List ");
            nList._printLnkList(nList.lhead);

            /* Convert List to BST */
            //convert LinkedList to BST first
            Node root = nList.sortedListToBST();

            Console.WriteLine("");
            Console.WriteLine("Balanced Search Tree ");
            nList.preOrderLnk(root);

            //then check if the BST is balances or not
            if (nList.isBalanced(root))
            {
                Console.WriteLine("Tree is balanced");
            }
            else
            {
                Console.WriteLine("Tree is not balanced");
            }
        }

        static void LinkedListToBST() {
            NodesAndLinkedLists nList = new NodesAndLinkedLists();
            /* create a sorted 
            7->6->5->4->3->2->1 */
            nList.pushLnkNode(7);
            nList.pushLnkNode(6);
            nList.pushLnkNode(5);
            nList.pushLnkNode(4);
            nList.pushLnkNode(3);
            nList.pushLnkNode(2);
            nList.pushLnkNode(1);

            Console.WriteLine("Linked List ");
            nList._printLnkList(nList.lhead);

            /* Convert List to BST */
            Node root = nList.sortedListToBST();
            Console.WriteLine("");
            Console.WriteLine("Pre-Order Traversal of constructed BST ");
            nList.preOrderLnk(root);
        }

        static void BinarySearchTree() {
            //head::also known as root
            NodesAndLinkedLists tree = new NodesAndLinkedLists();
            int[] arr = new int[] { -10, -3, 0, 5, 9 };
            int n = arr.Length;

            //leetcode
            // tree.head = tree.SortedArrayToBST(arr);

            // tree.head = tree._sortedArrayToBST(arr, 0, n - 1);           

            tree.head = tree.createMinimalBST(arr);

            Console.WriteLine("Preorder traversal of constructed BST");           

           tree.preOrder(tree.head);
        }

        static void _GraphCanBeConnected() {

            // Create a graph and pass number of graph vertices
            Graph g = new Graph(4); 
            g.addEdge(0, 1);
            g.addEdge(0, 2);
            g.addEdge(1, 2);
            g.addEdge(2, 0);
            g.addEdge(2, 3);
            g.addEdge(3, 3);
            int u = 1;
            int v = 3;
            if (g._isReachable(u, v))
                Console.WriteLine("There is a path from " + u + " to " + v);
            else
                Console.WriteLine("There is no path from " + u + " to " + v);
            u = 3;
            v = 1;
            if (g._isReachable(u, v))
                Console.WriteLine("There is a path from " + u + " to " + v);
            else
                Console.WriteLine("There is no path from " + u + " to " + v);
        }
    

        static void _rotateImgDriver(int [][] matrix)
        {
            Console.WriteLine("_original image \n");
            DisplayRotatedImage(matrix);
            Console.WriteLine("_rotated image \n");
            DisplayRotatedImage(RotateImage(matrix));
        }

        static void _canbeRotated() {


        }

        static bool checkRotation(int[][] matrix, int[][] target)
        {
            // max number of rotations is 4 --> 360 degrees
            for (int i = 0; i < 4; i++)
            {
                if (Equals(matrix, target)) // Checking two matrices are equal or not.
                    return true;
                matrix = _rotateMatrix(matrix); ;
            }
            return false;
        }

        //function  to rotate a matrix 
        public static int[][] _rotateMatrix(int[][] matrix)
        {
            int n = matrix.Length;
            // create a new matrix called rotatedMat with the length of mat matrix to store the rotated matrix.
            int[][] rotatedMat = new int[n][];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // new row = prev column new column = n - 1 - prev row
                    rotatedMat[j][n - 1 - i] = matrix[i][j];
                }
            }
            return rotatedMat;
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

            // print elements after Pop()
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
       
        // functions to get minimum of two integers
        static int min(int x, int y)
        {
            return x < y ? x : y;
        }

        // Utility functions to get maximum of two integers
        static int max(int x, int y)
        {
            return x > y ? x : y;
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


        // rotate a N x N matrix by 90 degrees in anti-clockwise direction
        /*
         *  Time Complexity: O(n*n), where n is side of array.  O(N2)
            A single traversal of the matrix is needed.
            Space Complexity: O(1). 
            As a constant space is needed
        */
        static void _rotateMatrix(int N, int[,] mat)
        {
            // consider all squares one by one
            for (int x = 0; x < N / 2; x++)
            {
                // consider elements in group of 4 incurrent square
                for (int y = x; y < N - x - 1; y++)
                {
                    // store current cell in temp variable
                    int temp = mat[x, y];

                    // move values from right to top
                    mat[x, y] = mat[y, N - 1 - x];

                    // move values from bottom to right
                    mat[y, N - 1 - x] = mat[N - 1 - x, N - 1 - y];

                    // move values from left to bottom
                    mat[N - 1 - x, N - 1 - y] = mat[N - 1 - y, x];

                    // assign temp to left
                    mat[N - 1 - y, x] = temp;
                }
            }
        }

        //rotate clockwise

        static void _rotateMatrix_Clockwise(int N, int[,] mat)
        {
            // consider all squares one by one
            for (int y = 0; y < N / 2; y++)
            {
                // consider elements in group of 4 incurrent square
                for (int x = y; x < N - y - 1; x++)
                {
                    // store current cell in temp variable
                    int temp = mat[y, x];

                    // move values from left to top
                    mat[y, x] = mat[x, N - 1 - y];

                    // move values from bottom to left
                    mat[x, N - 1 - y] = mat[N - 1 - y, N - 1 - x];

                    // move values from right to bottom
                    mat[N - 1 - y, N - 1 - x] = mat[N - 1 - x, y];

                    // assign temp to left
                    mat[N - 1 - x, y] = temp;
                }
            }
        }

        // print the rotated matrix
        static void _printMatrix(int N,  int[,] mat)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(" " + mat[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        //rotate matrix driver code

        static void _matrixRotate() {

            int N = 4;

            // Test Case 1
            int[,] mat = {

                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }

              };

            // Tese Case 2
            /* int mat[][] =
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            */            

            //print original matrix
            Console.WriteLine("original matrix: \n");
            _printMatrix(N, mat);

            //rotate anticlockwise
            _rotateMatrix(N, mat);

            //rotate clockwise
           // _rotateMatrix_Clockwise(N, mat);

            // Print rotated matrix
            Console.WriteLine("rotated matrix: \n");
            _printMatrix(N, mat);
        }

        /* Rotate Matrix: Given an image represented by an NxN matrix, where each pixel in the image is 4
         bytes, write a method to rotate the image by 90 degrees. Can you do this in place? */

        //rotate image sides : clockwise rotation
        static int[][] RoatateImageSides(int start, int end, int[][] _img)
        {
            for (int i = start; i <= end - 1; i++)
            {
                int offset = i - start;
                int temp = _img[start][i];
                _img[start][i] = _img[end - offset][start];
                _img[end - offset][start] = _img[end][end - offset];
                _img[end][end - offset] = _img[i][end];
                _img[i][end] = temp;
            }
            return _img;
        }

        //rotate image
        static int[][] RotateImage(int[][] inputImage)
        {
            for (int i = 0; i < inputImage.Length / 2; i++)
            {
                inputImage = RoatateImageSides(i, inputImage.Length - i - 1, inputImage);
            }
            return inputImage;
        }

        static void DisplayRotatedImage(int[][] imgMatrix)
        {
            int length = imgMatrix[0].Length;
            for (int i = 0; i < length; i++)
            {
                string a = "";
                for (int j = 0; j < length; j++)
                {
                    a += imgMatrix[i][j] + " ";
                }
                Console.WriteLine(a);
            }
        }

       
    }
}
