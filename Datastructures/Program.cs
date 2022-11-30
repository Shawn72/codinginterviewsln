using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using static Datastructures.ListsNodeTrees;

namespace Datastructures
{
    class Program
    {
        public static Arrays arrys = new Arrays();
        public static Matrix mtrx = new Matrix();
        public static BitsManipulation bt = new BitsManipulation();
        public static NodesAndLinkedLists lstNode = new NodesAndLinkedLists();
        public static DoubleLinkedList dllNodes = new DoubleLinkedList();
        static void Main(string[] args)
        {
            //  string s1 = "hello" + "i" + "am";
            //  Console.WriteLine(s1);

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
            // Console.WriteLine( "compressed: "+_compressString("aaabbbrrrruuuuu") );
            // Console.WriteLine("Can form a palidrome?: " + _canFormPalindrome("cooc") );
            // Console.WriteLine("palidrome: " + _getPalindrome("mdaam"));
            // Console.WriteLine("UrLified string: " + URLify_String("http://ninjax company ltd.com"));
            // lstNode._GetKthElementofLinkedList(3); //put n position

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

            //graphs
            // _GraphCanBeConnected();            
            //  LinkedListToBST();
            // _checkBSTHeightBalance();
            // MaximumTreeDepth();
            //  minArrayOp();
            // _minOpstomakeArrayEqual();
            // _UpdateBits();
            //  ZeroMatrix();
            // _printBinarytostring();
            //_FlipBitOnce();
            // _NextSmallestorLargest();
            // countFlippedBits();
            // SwapOddEvenBits();
            // CatsArrtoList();
            // _ConvertListto2Darray();

            //TestArrayManipulation ();

            ///push all 0s to end test
            //int[] testArr = { 5, 6, 0, 4, 6, 0, 9, 0, 8, 10, 0, 0 };
            //PushAllZerosToEnd(testArr);


            ///add without operator test
            // AddWOOperator(5, 10);
            // var sum =  AddMe(5, 10);
            // Console.WriteLine("sum is: " + sum);


            //int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };
            // SortArray(arr);        


            //print leetcode sorted array
            // Console.WriteLine("my sorted array: " +ArrayPrintHelper(SortMeArray(arr)));

            //AbstrctClsTest();

            ///word counter test
            // string[] wrdarr = { "the", "dog", "got", "the" , "bone"};         
            //MyWordCounter(wrdarr);


            ///string reshape test
            //Reshape("mungu   ni mwema ii" , 3);

            //CallSealedClass();

            ///unique chars in a string test
            //Console.WriteLine("Is Unique: " +UniqueChar("mbuUvi") );

            ///minimal largest sum test
            //int[] arr = { 2, 1, 5, 1, 2, 2, 2 };
            // Console.WriteLine("Minimal Large Sum: "+MinMaxDivisionSolution(3, 5, arr));

            ///merge sort test
            //int[] nums = { 5, 2, 3, 1 };
            //var sortedNums = Merge_SortArray(nums);
            //_printMergeSort(sortedNums);


            ///greedy algo test
            // int[] a = { 1, 3, 7, 9, 9 }; int[] b = { 5, 6, 8, 9, 10 };
            // Console.WriteLine("size of non-overlapping set: " + GreedyNonOverlappingSolution(a, b));


            ///unique occurence using hashmaps test
            //int[] arr = { 1, 3, 4, 3, 5, 7 };
            // Console.WriteLine("Is the array unique: " + UniqueOccurrenceOfElement(arr));


            ///quicksort test
            //int[] arr = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
            //int n = arr.Length; //length of the array
            //quickSort(arr, 0, n - 1);
            //Console.Write("Quick Sorted Array: ");
            //_printAnySortedArray(arr);

            ///heapsort test
            //var arr = new int[] { 73, 57, 49, 99, 133, 20, 1 };
            //var expected_result = new int[] { 1, 20, 49, 57, 73, 99, 133 };
            //var sortedArray = HeapSortArray(arr, arr.Length);
            //_printAnySortedArray(sortedArray);

            ///binary search test
            ///array to search MUST always be sorted
            //var sortedarr = new int[] { 1, 20, 49, 57, 73, 99, 133, 150 };
            // Console.Write("Binary Search a Quick Sorted Array, ");
            //var bSearch = BinarySearch(arr, 85);
            ///or use inbuild binarySearch function
            //var bSearch = Array.BinarySearch(sortedarr, 20);
            // Console.WriteLine("Binary Search Results, is at index: " + bSearch);

            //int arrLen = sortedarr.Length;
            //int high = arrLen - 1;
            //var RBsearch = RecursiveBinarySearch(sortedarr, 57, 0, high);
            //Console.WriteLine("Recursive Binary Search: " + RBsearch);

            ///reverse string without libraries
            // Console.WriteLine("Reverse my String is: "+_ReverseStrWoLib("mbuvi"));
            // Console.WriteLine("string reversed: " + _ReverseStrNoLibII("mbuvi"));

            ///remove dups from array
            //int[] nums = { 1, 1, 1, 2, 2, 3};
            // var rDps = removeDuplicatesFromArray(nums);
            // var rDps = _RemoveDupsII(nums);
            // Console.WriteLine("Length of new array after removing dups: " + rDps);
            //we can use inbuild function Array.Sort(arr) to quickly sort array in asc order

            ///check if linked list is circular
            //lstNode.MakeListCircular();

            ///insertion sort
            // int[] arr = { 3, 7, 10, 4, 6, 12 };
            // var inSort = InsertionSort(arr);
            // _printAnySortedArray(inSort);

            ///TwoSum soln
            //int[] nums = { 1, 2, 4, 5, 4, 6 };
            //var SumofTwo = TwoNums(nums, 10);
            //_printAnySortedArray(SumofTwo);

            ///maximum binary gap
            //Console.WriteLine("gap length: " + MaximumBinaryGap(22));

            ///maximum difference
            //int[] nums = { 2, 7, 9, 5, 1, 3, 5 };
            // Array.Sort(nums);
            // Console.WriteLine("maximum difference: " + GetMaximumDifference(nums));

            ///maximum sorted diff of adjacent elements
            //int[] arr = { 2, 4, 8, 11 };
            //Console.WriteLine("max diff: " + MaximumSortedAdjacentDiff(arr));

            ///palindrome check
            // StrPalindromeChecker("pool");
            //IsStrPalindrom("boob");

            ///integer palindrome check
            //IsIntegerPalindrome(121);

            ///doubly linked list
            //var listIs = dllNodes.CreateDoulblyLinkedList();
            //dllNodes._printDoublyLinkedList(listIs);

            ///create binary search tree
            //int[] arr = { 2, 3, 5, 6, 8, 10 };
            //// BinarySearchTree(arr); //we can use recusrion
            ////or use below
            //var myNode = lstNode.SortedArrayToBST(arr);
            //lstNode.preOrder(myNode); //print binary tree

            ///maximum pair tests
            //int[] arr = { -2, -8, -3, 8, 10,-15, 9 };
            int[] m = { 3, 4, 5, 2 };
            //MaxProductPair(m);
            Console.WriteLine("Max Product: " + maxProduct(m));

            //below code should come at the bottom, make cmd not disappear
            Console.ReadLine();
        }


        // use Partitioning the array: why i used it, is simple ,dont require too much writing,
        // fast to implement
        // use a 0 as a pivot, see non 0 element and swap it going left

        //Complexity Analysis:
        //Time Complexity: O(N)
        //Auxiliary Space: O(1)
        static void PushAllZerosToEnd(int [] arr)
        {
            int n = arr.Length; // array length
            int j = 0; // our pivot element, current element index
            for (int i = 0; i < n; i++) //traverse the array
            {
                if (arr[i] != 0) //if current root element index is not equal to 0
                {
                    //int temp = arr[j];
                    //arr[j] = arr[i];
                    //arr[i] = temp;

                    //call swap
                    swapElements(arr, i, j);

                    //increment current index
                    j++;
                }
            }
            for (int i = 0; i < n; i++) //for writing the output
            {
                Console.Write(arr[i]); //write all in  a single line, no use WriteLine
                Console.Write(" ");
            }

        }

        static void TestArrayManipulation() {

            int n = 5;
            int[][] queries = new int[3][];

            int k = queries.Length;
          //  queries[0] = new int[] { 1, 2, 100 };
          //  queries[1] = new int[] { 2, 5, 100 };
          //  queries[2] = new int[] { 3, 4, 100 };


            int[,] arr = { { 1, 2, 100 }, { 2, 5, 100 }, { 3, 4, 100 } };

            int j = arr.Length;

            List<List<int>> nestedlst = arrys.NList(arr);
            // arrys.NestedList();
            // arrys.Display(nestedlst);
            //convert nested list to int[][]
            int[][] nDarray = arrys._ListTo2DArray(nestedlst);
            int g = nDarray.Length;
            long result = arrys.arrayManipulation(n, nDarray);
            Console.WriteLine(result);
         
        }


        static void _ConvertListto2Darray() {
            // int[][] arr = {new int[] { 2, 3 }, new int[]{ 2, 3 }, new int[]{ 2, 3 } };
            //convert to nested list
            int[,] arr = { { 2, 3, 7 }, { 2, 3, 5 }, { 2, 3, 6 }, { 2, 4, 7 }, { 2, 4, 5 }, { 2, 4, 6 } };
            List< List<int> > nestedlst = arrys.NList(arr);
            // arrys.NestedList();
            // arrys.Display(nestedlst);
            //convert nested list to int[][]
            int[][] nDarray = arrys._ListTo2DArray(nestedlst);
            Console.WriteLine("2D Array: " + nDarray);
        }

        static void ConvertArrayToList() {
            int[,] arr = { { 2, 3, 7 }, { 2, 3, 5 }, { 2, 3, 6 }, { 2, 4, 7 }, { 2, 4, 5 }, { 2, 4, 6 } };
            // Console.WriteLine("List: " + arrys.CastToList(arr));
            Console.WriteLine("List: " + arrys.UsingBlockCopy(arr));
        }

        static void SwapOddEvenBits() {
            int n = 23;
            string b = _convertIntToBinary(n);
            Console.WriteLine("original no. : "+n+": bits: " + b);
            //swap odd/ even bits
            int sw = bt.swapBits(n);
            string b2 = _convertIntToBinary(sw);
            Console.WriteLine("no. after bit swap : "+sw+": bits after swap: " + b2);

        }

        static string _convertIntToBinary(int m) {         
            
            string binary = string.Empty;
          
            //int remainder;

            //convert integer back to binary string
            //while (m > 0)
            //{
            //    remainder = m % 2;
            //    m /= 2;
            //    binary = remainder.ToString() + binary;
            //}

            //or simply use this
            binary = Convert.ToString(m, 2); //convert to string with base 2

            return binary;
        }

        static void countFlippedBits() {
            int a = 12, b = 18;
            Console.WriteLine("bits to flip: " + bt.FlippedCount(a, b));
        }

        static void _NextSmallestOrLargest() {

            int n = 5;
            Console.WriteLine("next largest / smallest int: "+bt.getNext(n));
            Console.WriteLine("prev largest / smallest int: " + bt.getPrev(n));

        }

        static void _FlipBitOnce() {
            //length of the longest sequence
            int flippedbits = bt.flipBit(1775);
            Console.WriteLine("length of the longest sequence: " + flippedbits);

        }

        //zerofy matrix if one element in row or column is 0
        static void ZeroMatrix() {

            int [][] matrix =   new int[][] {
                                new int []{0,1,2,3,4,5},
                                new int []{0,1,2,3,4,5},
                                new int []{0,1,2,3,4,5},
                                new int []{0,1,2,3,4,5},
                                new int []{0,1,2,3,4,5},
                                new int[]{0,1,2,3,4,5}  };

		    Console.WriteLine("row = " + matrix.Length + " column = " + matrix[0].Length);

            mtrx._setMatrixZero(matrix);
            Console.WriteLine("After setZero: \n");
		    for(int i = 0; i<matrix.Length; i++){

			    for(int j = 0; j<matrix[0].Length; j++){
				    Console.WriteLine(matrix[i][j] + " \n");
                    }
            
                }
        }

        static void _printBinarytostring() {
           // Console.WriteLine("binary: " + bt._printBinary(0.625));
            Console.WriteLine("binary: " + bt.printBinaryPoint5(0.625));
            

        }

        static void _UpdateBits (){
            var p = "10000000000"; 
            var q = "10011";

            //convert binary string to int // Convert.ToInt32(p, Base / Int32);
            int n = Convert.ToInt32(p, 2);
            int m = Convert.ToInt32(q, 2);
            int i = 2, j = 6;

            //expected output n = 10001001100

            int  newBits =  bt.updateBits(n, m, i, j);

            int decimalNumber = newBits;
            int remainder;
            string binary = string.Empty;

            //convert integer back to binary string
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                binary = remainder.ToString() + binary;
            }
            Console.WriteLine("after bit manipulation: " + binary);       
        }

        static void minArrayOp() {

            // int[] arr = { 1, -4, -3, 0, 9, -8 };
            int[] arr = { 1, 5, 7, 10 };
            int len = arr.Length;
            int minOp = arrys.LeetCodeMinOperations(len); ;
            Console.WriteLine("minimum operations: "+ minOp);
        }

        static void _minOpstomakeArrayEqual() {
           // int[] arr = { 1, -4, -3, 0, 9, -8 };
            int[] arr = { 1, 5, 7, 10 };

            int minOps = arrys.minimumOpsCost(arr);
            Console.WriteLine("minimum operations: " + minOps);
        }

        static void MaximumTreeDepth() {

            //head: used as root
            //_pushtoNode pushes to head, _pushtLnkNode pushes to lhead
            NodesAndLinkedLists nList = new NodesAndLinkedLists();
            /* create a sorted linked list
            7->6->5->4->3->2->1 */
            //  3,9,20,null,null,15,7

            nList.pushLnkNode(3);
            nList.pushLnkNode(9);
            nList.pushLnkNode(20);
            nList.pushLnkNode(null);
            nList.pushLnkNode(null);
            nList.pushLnkNode(15);
            nList.pushLnkNode(7);

            Console.WriteLine("Linked List ");
            nList._printLnkList(nList.lhead);

            /* Convert List to BST */
            //convert LinkedList to BST first
            Node root = nList.sortedListToBST();
            Console.WriteLine("Maximum depth: "+ nList.maximumDepth(root));    
            
        }

        static void _checkBSTHeightBalance()
        {
            //head: used as root
            //_pushtoNode pushes to head, _pushtLnkNode pushes to lhead
            NodesAndLinkedLists nList = new NodesAndLinkedLists();
            /* create a sorted linked list
            7->6->5->4->3->2->1 */
          //  3,9,20,null,null,15,7

            nList.pushLnkNode(3);
            nList.pushLnkNode(9);
            nList.pushLnkNode(20);
            nList.pushLnkNode(null);
            nList.pushLnkNode(null);
            nList.pushLnkNode(15);
            nList.pushLnkNode(7);

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

        static void BinarySearchTree(int[] arr) {

            //head::also known as root
            NodesAndLinkedLists tree = new NodesAndLinkedLists();

            //int[] arr = new int[] { -10, -3, 0, 5, 9 };
            int n = arr.Length;

            //leetcode solutions
            // tree.head = tree.SortedArrayToBST(arr);

             tree.head = tree._sortedArrayToBST(arr, 0, n - 1);           

           // tree.head = tree.createMinimalBST(arr);

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
        
        //rotate matrix driver code
        static void _matrixRotate()
        {

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
            mtrx._printMatrix(N, mat);

            //rotate anticlockwise
            mtrx._rotateMatrix(N, mat);

            //rotate clockwise
            // _rotateMatrix_Clockwise(N, mat);

            // Print rotated matrix
            Console.WriteLine("rotated matrix: \n");
            mtrx._printMatrix(N, mat);
        }

        static void _rotateImgDriver(int [][] matrix)
        {
            Console.WriteLine("_original image \n");
            mtrx.DisplayRotatedImage(matrix);
            Console.WriteLine("_rotated image \n");
            mtrx.DisplayRotatedImage(mtrx.RotateImage(matrix));
        }             
         

        static string URLify_String(string strn) {

            char[] str = strn.ToCharArray();
            string urlfied = "";

            // Prints the replaced string
            str = arrys._URLifyString(str);


            for (int i = 0; i < str.Length; i++) {
                urlfied += str[i];
            }
            return urlfied;
        }

        static void _reverseIntArrCode(int[] arr)
        {
            Console.Write("original array is \n");
            arrys.printArray(arr, 7);
            //reverse array
            arrys._reverseArray(arr, 0, 6);
            //then print after reverse
            Console.Write("reversed array is \n");
            arrys.printArray(arr, 7);
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
            // add elements in the Stack using Push method           
            _stack.Push("Shawn");
            _stack.Push("Woman");
            _stack.Push("Nina");
            _stack.Push("Clarke");

            // access the elements of stack using foreach loop
            foreach (var elem in _stack)
            {
                Console.WriteLine("element: " + elem);
            }
            Console.WriteLine("\n");

            var indexTop = _stack.Cast<string>().First();
            var indexBottom = _stack.Cast<string>().Last();

            Console.WriteLine("first element: " + indexBottom);
            Console.WriteLine("last element: " + indexTop);
            Console.WriteLine("\n");

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


        /// <summary>
        /// using bitwise XOR (^)
        /// time complexity: O (log b)
        /// </summary>
        public static void AddWOOperator(int a, int b)
        {
            // Iterate till there is no reminder to carry
            while (b != 0)
            {              
                // set bits of a and b
                int rem = a & b; 

                // Sum of bits of a and b where at least one of the bits is not set
                a = a ^ b; //add wothout carrying

                // rem is shifted by one bit so that adding it to a gives the required sum
                b = rem << 1;
            }
            Console.WriteLine("-- sum of the integers--");
            Console.WriteLine(a);
        }

        //add 2 numbers using recusion and bitwise
        static int AddMe(int m, int n)
        {
            if (n == 0)
                return m;
            else //call the function recursively
                return AddMe(m ^ n, (m & n) << 1); //( (m^n)-add without carry,
                                                   //(m & n) << 1 - carry, but no add ) 
        }

        //sort array desc order

        static void SortArray(int [] arr)
        {           

            // Sort array in ascending order by default.
            Array.Sort(arr);

            // Reverse array, if u want to get descending order
            // Array.Reverse(arr);

            // print all element of array
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
        }


        /// <summary>
        /// for leetcode solution
        /// </summary>
        static int[] SortMeArray(int[] nums)
        {
            //initialize results array with length of the array size given
            int[] res = new int[nums.Length];   

            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = nums[i];
            }
            Array.Sort(res); //default sort //use it for asc
            Array.Reverse(res); //for desc , specifically, use both
            return res;
        }

        //array printer helper: call it whenever u want to output
        static string ArrayPrintHelper(int[] arr)
        {
            string ars = "";
            // print all element of array
            foreach (int val in arr)
            {                
                ars += val + " ";
            }
            //return concatenated string
            return ars;
        }

        //abstract class test
        static void AbstrctClsTest()
        {
            var vehicle = new Vehicle()
            {
                Owner = "Bob",
                YearofRegistration = "2020"
            };

            var newVehicle = new Vehicle();
            newVehicle = vehicle;

            newVehicle.Owner = "Mary"; //new owner is assigned, so Bob is overwritten
            newVehicle.YearofRegistration = "2021";

            Console.WriteLine("properties of vehicle, Owner:"+vehicle.Owner+" YoM: "+vehicle.YearofRegistration);
        }

        //string occurances
        //return count of occurrences of str in str_arr[] 
        static void MyWordCounter(string[] str_arr)
        {          

            var wordcounter = str_arr
                .GroupBy(w => w)
                .Select(g => new { Word = g.Key, Count = g.Count() })
                .ToList();

            foreach (var oneword in wordcounter)
            {
                Console.WriteLine("Word: '{0}' Occurence: {1} times ", oneword.Word, oneword.Count);
            }
        }   
        
        //reshape, remove all spaces and lay it out
        static void Reshape(string str, int n)
        {        
            //n = number of characters in each line ( chunk size )
            str = str.Replace(" ", ""); //remove spaces first
            string txtResults = "";

            //split string into a n-lengthed list of strings
            var aLine = Enumerable.Range(0, str.Length / n)
                .Select(i => str.Substring(i * n, n)).ToList();

            //check if there are any characters left after split, if so add the rest
            if (str.Length > ((str.Length / n) * n))
                aLine.Add(str.Substring((str.Length / n) * n));


            Console.WriteLine("reformatted string: ");

            //create return strings, with extras factored in           
            foreach (string Line in aLine)
                txtResults += Line  + Environment.NewLine;

            Console.WriteLine(txtResults);                  
        }

        //split string in given chunks, truncate reminder
        static IEnumerable<string> SplitTheString(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }


        // general questions
        // 1. What is abstraction:  is the process of hiding certain details and
        //    showing only essential information to the user.
        //    can be implemented using abstract classes and interfaces

        // 2. What is an abstract class: is a restricted class that cannot be used to create objects
        // (to access it, it must be inherited from another class)

        // 3. Abstract method: can only be used in an abstract class, and it does not have a body.
        //The body is provided by the derived class (inherited from).
        // eg .abstact class Animal(){ abstract void animalSound();...abstarct method }
        // Animal myObj = new Animal(); // Will generate an error
        // (Cannot create an instance of the abstract class or interface 'Animal')

        //implementation of abstract class

        // Derived class (inherit from Animal)
        //e.g.  class Pig : Animal
        // {
        //     public override void animalSound() //override animalSound method and create a body now
        //     {
        //         // The body of animalSound() is provided here
        //         Console.WriteLine("The pig says: wee wee");
        //     }
        // }

        // 4. An interface is a completely "abstract class",
        //which can only contain abstract methods and properties (with empty bodies):

        // eg. interface
        //interface Animal
        //{
        //    void animalSound(); // interface method (does not have a body)
        //    void run(); // interface method (does not have a body)
        //}


        //sealed class: is a class that can not be inherited, and it's methods cant be overriden
        //sealing a class takes away inheritance
        //scenario, for db helper class with sensitive info u dont want inheritted

        //eg.
        sealed class SealedClassTest
        {
            public int Add(int x, int y)
            {
                return x + y;
            }
        }

        static void CallSealedClass()
        {
            SealedClassTest sc = new SealedClassTest();
            int total = sc.Add(4, 5);
            Console.WriteLine("Sealed Total = " + total.ToString());
        }

        //class InheritSealed: SealedClassTest
        //{
        //    //this class throws the following error:
        //    //: cannot derive from sealed type 'Program.SealedClassTest,
        //    //...Unseal class to enable inheritance
        //}  

        //Binary Serach Algorithm: MinMaxDivision
        ///MinMaxDivision(Divide array A into K blocks and minimize the largest sum of any block.)
        ///You are given integers K, M and a non-empty zero-indexed array A consisting of N
        ///integers.Every element of the array is not greater than M.       
        ///You should divide this array into K blocks of consecutive elements.The size of the block is any
        ///integer between 0 and N. Every element of the array should belong to some block.
        ///The sum of the block from X to Y equals A[X] + A[X + 1] + ... + A[Y]. 
        ///The sum of empty block equals 0.The large sum is the maximal sum of any block.
        ///For example, you are given integers K = 3, M = 5 and array A such that: A[0] = 2,  A[1] = 1,
        /// A[2] = 5,  A[3] = 1,  A[4] = 2,   A[5] = 2,    A[6] = 2
        /// 
        /// * The array can be divided, for example, into the following blocks:
        /// * [2, 1, 5, 1, 2, 2, 2], [], [] with a large sum of 15;
        /// * [2], [1, 5, 1, 2], [2, 2] with a large sum of 9;
        /// * [2, 1, 5], [], [1, 2, 2, 2] with a large sum of 8;
        /// * [2, 1], [5, 1], [2, 2, 2] with a large sum of 6.
        /// * The goal is to minimize the large sum.In the above example, 6 is the minimal large sum.
        /// * Write a function:
        /// * class Solution { public int solution(int K, int M, int[] A); }
        /// * that, given integers K, M and a non-empty zero-indexed array A consisting of N integers, returns the minimal large sum.
        /// * For example, given K = 3, M = 5 and array A such that:
        /// *   A[0] = 2
        /// *   A[1] = 1
        /// *   A[2] = 5
        /// *   A[3] = 1
        /// *   A[4] = 2
        /// *   A[5] = 2
        /// *   A[6] = 2 
        /// 
        /// * the function should return 6, as explained above.
        /// * Assume that:
        /// * N and K are integers within the range[1..100, 000];
        /// * M is an integer within the range[0..10, 000];
        /// * each element of array A is an integer within the range[0..M].
        /// * Complexity:
        /// * expected worst-case time complexity is O(N* log(N+M));
        /// * expected worst-case space complexity is O(1), beyond input storage(not counting the storage required for input arguments).
        /// Codility Solution below
        /// 

        public static int MinMaxDivisionSolution(int K, int M, int[] A)
        {
            //initialize largest element in array, sum and result
            int largest = 0; int sum = 0; int result = 0;

            for (int i = 0; i < A.Length; i++)
            {
                //get the sum, and the largest array element
                sum += A[i];
                largest = Math.Max(largest, A[i]);
            }
            //res is the sum
            result = sum;

            while (largest <= sum)
            {
                //get mid index element
                int mid = (largest + sum) / 2;

                if (IsDivideSolvable(mid, K - 1, A))
                {
                    sum = mid - 1;
                    result = mid;
                }
                else
                {
                    largest = mid + 1;
                }
            }
            return result;
        }

        public static bool IsDivideSolvable(int mid, int k, int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
                if (sum > mid)
                {
                    sum = a[i];
                    k--;
                }
                if (k < 0)
                {
                    return false;
                }
            }
            return true;

        }

        ///Sorting Algorithms
        ///
        //1 . Merge Sort: is based on divide and conquer paradigm, divide array into 2 halves, sort each and merge results back to one Big array: 
        //Time Complexity: O(n log n ) -best, average and worst cases
        //it's more stable
        ///Given an array of integers nums, sort the array in ascending order and return it.
        ///You must solve the problem without using any built-in functions in O(nlog(n)) time complexity
        ///and with the smallest space complexity possible.
        ///Example 1:
        ///Input: nums = [5,2,3,1]
        ///Output: [1,2,3,5]
        ///Explanation: After sorting the array,
        ///the positions of some numbers are not changed(for example, 2 and 3),
        ///while the positions of other numbers are changed(for example, 1 and 5).
        ///
        //leetcode solution

        //create array merge() helper
        public static void mergeArray(int low, int mid, int high, int[]arr)
        {
            int[] merge_helper = new int[high - low + 1];

            for (int k = low; k <= high; k++) //k: current index
            {
                merge_helper[k - low] = arr[k];
            }

            int i = low, j = mid + 1;
            int idx = low; //initialize index to var low 

            while (i <= mid && j <= high)
            {
                if (merge_helper[i - low] < merge_helper[j - low])
                {
                    arr[idx++] = merge_helper[i++ - low];
                }
                else
                {
                    arr[idx++] = merge_helper[j++ - low];
                }
            }

            while (i <= mid)
            {
                arr[idx++] = merge_helper[i++ - low];
            }
        }
        public static void mergeSort(int low, int high, int[]nums)
        {
            //low: starting index, high: ending index, nums: array to be sorted

            if (low >= high) return;

            int mid = low + (high - low) / 2;

            mergeSort(low, mid, nums); //left node

            mergeSort(mid + 1, high, nums); //right node

            mergeArray(low, mid, high, nums); //merge both
        }

        //leetcode main function to call
        public static int[] Merge_SortArray(int[] nums)
        {           
            mergeSort(0, nums.Length - 1, nums);
            return nums;
        }

        public static void _printMergeSort(int[] arr)
        {
            //print out
            var m = @"";
            Console.WriteLine("Print Merged Sort: ");
            foreach (var l in arr)
            {
               m += l.ToString()+",";               
            }
            //remove the last comma
            Console.Write(m.Substring(0, m.Length - 1));
        }

        //Quick Sort: use highest element of the array as the pivot, uses divide and conquer strategy
        //quick sort is faster than merge sort
        //is unstable, recursive, very fast
        //complexity avearage and best case: O(n log n): rem halving, each time n increases by amount k, time or space increases by k/2 
        //worst case: O(n2)
        // A utility function to swap two elements, can be reused all over the project
        static void swapElements(int[] arr, int i, int j)
        {
            int temp = arr[i];  //temp storage first
            arr[i] = arr[j];  //swap
            arr[j] = temp; //assign temp val to index j
        }

        /* This function takes last element as pivot, places
         the pivot element at its correct position in sorted
         array, and places all smaller (smaller than pivot)
         to left of pivot and all greater elements to right
         of pivot */
        static int arr_partitioner(int[] arr, int low, int high)
        {
            // take highest index of larger element as pivot
            int pivot = arr[high];

            // Index of smaller element indicates the right position of pivot found so far
            int i = (low - 1);

            //int j: current index

            for (int j = low; j <= high - 1; j++)
            {
                // If current element is smaller than the pivot
                if (arr[j] < pivot)
                {
                    // Increment index of smaller element
                    i++;
                    swapElements(arr, i, j);//swap element at index i with element at index j
                }
            }
            swapElements(arr, i + 1, high);
            return (i + 1);
        }

        /* The main function that implements QuickSort
           arr[] --> Array to be sorted,
           low --> Starting index,
           high --> Ending index    */
        static void quickSort(int[] arr, int startingindex, int endingindex)
        {
            if (startingindex < endingindex)
            {
                // pi is partitioning index, arr[p] , is now at right place
                int pi = arr_partitioner(arr, startingindex, endingindex);

                // Separately sort elements before partition and after partition
                quickSort(arr, startingindex, pi - 1); //before partition
                quickSort(arr, pi + 1, endingindex);//after partition
            }
        }

        // print sorted array helper function
        static void _printAnySortedArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        //greedy algorithms tests
        /**
         * Located on a line are N segments, numbered from 0 to N − 1, whose positions are given in zero-indexed arrays A and B. 
         * For each I (0 ≤ I < N) the position of segment I is from A[I] to B[I] (inclusive).
         * The segments are sorted by their ends, which means that B[K] ≤ B[K + 1] for K 
         * such that 0 ≤ K < N − 1.
         * Two segments I and J, such that I ≠ J, are overlapping if they share at least one common point.
         * In other words, A[I] ≤ A[J] ≤ B[I] or A[J] ≤ A[I] ≤ B[J].
         * We say that the set of segments is non-overlapping if it contains no two overlapping segments. 
         * The goal is to find the size of a non-overlapping set containing the maximal number of segments.
         * For example, consider arrays A, B such that:
         *     A[0] = 1    B[0] = 5
         *     A[1] = 3    B[1] = 6
         *     A[2] = 7    B[2] = 8
         *     A[3] = 9    B[3] = 9
         *     A[4] = 9    B[4] = 10
         * The segments are shown in the figure below.
         * The size of a non-overlapping set containing a maximal number of segments is 3. For example, 
         * possible sets are {0, 2, 3}, {0, 2, 4}, {1, 2, 3} or {1, 2, 4}. There is no non-overlapping 
         * set with four segments.
         * Write a function:
         * class Solution { public int solution(int[] A, int[] B); }
         * that, given two zero-indexed arrays A and B consisting of N integers, returns the size of a
         * non-overlapping set containing a maximal number of segments.
         * For example, given arrays A, B shown above, the function should return 3, as explained above.
         * Assume that:
         * N is an integer within the range [0..30,000];
         * each element of arrays A, B is an integer within the range [0..1,000,000,000];
         * A[I] ≤ B[I], for each I (0 ≤ I < N);
         * B[K] ≤ B[K + 1], for each K (0 ≤ K < N − 1).
         * Complexity:
         * expected worst-case time complexity is O(N);
         * expected worst-case space complexity is O(N), beyond input storage 
         * (not counting the storage required for input arguments).
         * Elements of input arrays can be modified.
         */

        public static int GreedyNonOverlappingSolution(int[] A, int[] B)
        {
            int N = A.Length;
            if (N <= 1)
            {
                return N;
            }

            int count = 1;
            int prev_end = B[0];

            int curr_end;
            for (curr_end = 1; curr_end < N; curr_end++)
            {
                if (A[curr_end] > prev_end)
                {
                    count++;
                    prev_end = B[curr_end];
                }
            }

            return count;
        }

        //implementation of HashSets, Hashmaps to determine uniqueness of array elements
        //check if a str if it contains unique chars
        public bool UniqueChar(string str)
        {
            //mind about Lower or Upper cases, U is not u, returns True
            //assume is ASCII - 128 bit character max , 7bit = 1 char
            //assume char set is fixed to 128
            //ASCII - 128
            //Extended ASCII - 256 
            //unicode: wide range of lengths, 8bit, 16bit, 32bits = 1 char
            //ascii requires less space, unicode req more space :: tradeoff made

            //time complexity: O(n), n = length of str
            //space complexity: O(1)

            if (str.Length > 128) return false;// greater than ascii max char set;

            //create a boolean array set of 128 length

            bool[] chrset = new bool[128];

            //loop through all the characters in that str

            for (int i = 0; i < str.Length; i++)
            {

                //convert str to char array
                char[] k = str.ToCharArray();

                //get value of char at index i
                int valueAti = k[i]; //get ASCII code value for that character

                //check, if the char was already found return false, not unique
                if (chrset[valueAti])
                {
                    return false;
                }
                chrset[valueAti] = true;
            }
            //always return true
            return true;
        }

        ///hashmaps, hashsets, dictionaries
        public static bool UniqueOccurrenceOfElement(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return true;

            var lenOfArr = arr.Length;

            //initialize a dictionary to hold the key pair values
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < lenOfArr; i++)
            {
                var ValueAtindexI = arr[i];

                if (dic.ContainsKey(ValueAtindexI) ==false) //if the key is not in the dictionary, just add it
                {
                    dic.Add(i, ValueAtindexI); //use indexes as the keys to hold the values
                }
            }

            //initialize hashset for checking duplicates
            var hashSet = new HashSet<int>();

            foreach (var pair in dic)
            {
                //check if the hashset has duplicates
                if (hashSet.Contains(pair.Value))
                {
                    //not unique
                    return false;
                }
                //if key pair value dont exist in hashset, add it and return true
                hashSet.Add(pair.Value);
            }
            //unique
            return true;
        }

        // assignments = 1 Op hence O(1)
        // complexity: O(1)+O(1)+O(1)+O(n*n)+O(1)+O(n*n)
        // = O(4)+O(2n2)
        // = strikeout constants: O + O(n2)
        // pick largest: O(n2)


        //Heap Sort
        // 1). The heapify phase: In this phase, we transform the input array
        // into a max heap – a binary tree
        // in which the value of each node is greater than or equal to the value of its children nodes.
        // 2). The sort phase: In this phase, the max heap is repeatedly removed until only one element remains.
        //This is done by swapping the root node with the last element in the heap, and then ensuring that
        //the new root node satisfies the max heap property.
        //This process is repeated until only one element remains in the heap.

        /// The heap sort algorithm encounters its best-case time complexity 
        /// when it encounters identical elements.
        /// Therefore. when we have N number of elements:
        /// Removing every node from the heap takes constant time O(1).
        /// Since all elements are equal, we don’t need to keep building the max heap, 
        /// hence the algorithm takes N * O(1) time or O(N).
        /// However, since this scenario is rare, we can conclude that the best-case time complexity
        /// of the heap sort algorithm is O(N log N),..which is also the worst case

        /// features of Maximum Binary Heap
        ///     Every node will have at most two children.
        ///     Each parent node’s value will be always greater than its children
        ///     and there is no guarantee in its children’s order.
        ///     Root node value is always greater than all the nodes.
        /// 
        ///features of Minimum Binary Heap
        ///    Every node will have at most two children.
        ///    Each parent node’s value will be always less than its children
        ///    and there is no guarantee in its children’s order.
        ///    Root node value is always less than all the nodes.

        static void Heapify(int[] arr, int arr_size, int index)
        {
            //Max Heap Implementation 
            //steps to master

            var largestIndex = index; //index of the maximum element of the array arr[]
            var leftChild = 2 * index + 1; //create left child
            var rightChild = 2 * index + 2; //create right child

            //check if leftchild is > the largest element, if true, swap their positions
            if ( arr[leftChild] > arr[largestIndex] && leftChild < arr_size )
            {
                largestIndex = leftChild;
            }

            //check if rightchild is > the largest element, if true, swap their positions
            if ( arr[rightChild] > arr[largestIndex] && rightChild < arr_size )
            {
                largestIndex = rightChild;
            }            

            if (largestIndex != index)
            { 
                // 1. call swapElements for swapping
                swapElements(arr, index, largestIndex);

                // 2. parameters: array, arraysize, index
                Heapify(arr, arr_size, largestIndex);//recursively call Heapify until we build max heap
            }
        }

        //leatcode implementation
        //using max heap        
        public static int[] HeapSortArray(int[] arr, int arr_size)
        {
            //arr_size = arr.Length;
            if (arr_size <= 1)
                return arr;

            for (int i = arr_size / 2 - 1; i >= 0; i--) //half the size of array
            {
                // build max heap array:: right half
                Heapify(arr, arr_size, i); //i: index of current root element
            }

            for (int i = arr_size - 1; i >= 0; i--)
            {             
                // call swap
                swapElements(arr, 0, i); //swap first index (0) with the last index (i)

                Heapify(arr, i, 0);//build max heap array again:: left half
            }

            //return sorted array
            return arr;
        }

        ///Binary Search
        ///Given an array of integers arr which is sorted in ascending order:
        ///assumption(array is already sorted in asc order)
        ///and an integer target/search, write a function to search target in arr. 
        ///If target exists, then return its index. Otherwise, return -1.
        ///You must write an algorithm with O(log n) runtime complexity.
        
        //Iterative method
        //returns index of the target search parameter
        //space and time complexity:  O(1)
        //very efficient
        static int BinarySearch(int[] arr, int search) {

            int lowIndex = 0;
            int highIndex = arr.Length - 1;
            int midIndex;

            //use iteration
            while(lowIndex <= highIndex)
            {
                midIndex = (lowIndex + highIndex) / 2;

                if (arr[midIndex] < search)
                {
                    lowIndex = midIndex + 1;
                }
                else if (arr[midIndex] > search)
                {
                    highIndex = midIndex - 1;
                }
                else return midIndex;
            }
            return -1; //for error
        }

        /// implement binary search using recursion:: array MUST be SORTED first
        /// Space and Time complexity: O(log n) - act as trade off
        /// easy to implement
        public static int RecursiveBinarySearch(int[] nums, int target, int low, int high)
        {
            if (low > high) return -1; //error

            //find mid element
            int mid = (low + high) / 2; //if low+high = odd number, mid element will have .5,
                                        //take the floor, dicard .5

            if (nums[mid] < target)
            {
                //use recursion
                return RecursiveBinarySearch(nums, target, mid + 1, high); //search right half where target is located
                //master:: if element in the mid index < target, then recursive binary search
                //parameter order ( array, target, low( mid+1), high )
            }
            if (nums[mid] > target)
            {
                return RecursiveBinarySearch(nums, target, low, mid - 1); //left half where target is located
                //if element in the mid index  > target, then call recursive binary search
                //parameter order: ( array, target, low, high (mid-1) ) 
            }
            else return mid;
        }

        //Time Complexity:  O(n),..n => length of the string 
        //Space Complexity:  O(1):: no extra space
        public static string _ReverseStrNoLibII(string str)
        {
            string reverseStr = string.Empty; //initialize reverse string to empty on start

            //get string length
            int n = str.Length;

            //reverse the string, from the back, end position
            for (int i = n - 1; i >= 0; i--)
            {
                reverseStr += str[i]; //repeated n number of times
            }
            return reverseStr;
        }

        ///Reverse a string using any Library
        public static string _ReverseStrWithLib( string str )
        {
            int len = str.Length;
            char [] chars = str.ToCharArray(); //convert string to char array
            StringBuilder sb = new StringBuilder(len);
            for (int i = len - 1; i >= 0; i--) //starting position => the last index , len-1
            {
                sb.Append(chars[i]);
            }
            return sb.ToString();
        }

        ///leetcode solution: reverse string given character array:: use swap implementation
        /// Write a function that reverses a string.
        /// The input string is given as an array of characters s.
        /// You must do this by modifying the input array in-place with O(1) extra memory.
       public void ReverseCharStrs(char[] s ) {
            
            //initialize start and end indeces
            int startIndex = 0;
            int endIndex = s.Length - 1;

            while(startIndex <= endIndex){
                
                //create temp variable                
                char temp = s[startIndex];

                s[startIndex] = s[endIndex]; //idea is to just swap the characters until the loop terminates
               
                s[endIndex] = temp;

                //increment start index by 1 each time
                startIndex++;
                //decrement end index by 1 each time
                endIndex--;
            }
       }

        ///We can use this property of the sorted array containing duplicates
        ///to solve this question using the following steps —
        //1. Check if the current and the next element are equal.
        //2. If they are, we will skip the next element and will
        //continue the procedure as long as we encounter the duplicates.
        //3. If the elements are not duplicate, we will place the next (different)
        //element next to the current element.
        ///Time Complexity : We are scanning the array once, hence the time complexity will be O(n).
        ///Space Complexity:  Since we are forbidden to use the external data structure, the space complexity will be O(1).

        public static int removeDuplicatesFromArray(int[] nums)
        {
            //initialize length of the new updated array after removing dups
            int newLen = 0;            

            // Loop all the elements in the array
            for (int i = 0; i < nums.Length; i++)
            {
                //i: index of the current element, i+1: index of next element
                // If the current element is equal to the next element AND i < last index (n-1), we skip
                if ( nums[i] == nums[i + 1] && i < nums.Length - 1 )
                {
                    continue; //skip it
                }

                // We will update the new array in place
                nums[newLen] = nums[i];
                newLen++; //increment newLen, rem it starts at 0
            }
            return newLen; //return new length
        }

        ///In this problem Remove Duplicates from Sorted Array II 
        ///problem solution we have Given an integer array nums
        ///sorted in non-decreasing order, 
        ///remove some duplicates in-place 
        ///such that each unique element appears at most twice.
        ///The relative order of the elements should be kept the same
        ///
        static int _RemoveDupsII(int[] nums)
        {
            int len = nums.Length;

            if (len == 0) return 0;
            
            int x = 1, newLen = 0; //x: kind of a flag, newLen: new array length

            for (int i = 0; i < len - 1; i++)
            {
                if (nums[i] == nums[i + 1] && x == 1)
                {
                    x++; //increment the flag
                    nums[newLen++] = nums[i]; //next will be current
                }
                else if (nums[i] != nums[i + 1]) //if current is not equal to next
                {
                    x = 1; //set flag to 1
                    nums[newLen++] = nums[i]; //assign next to current
                }
            }

            nums[newLen++] = nums[len - 1];
            //for test::
            Console.Write("new array is: "); 
            _printAnySortedArray(nums);

            return newLen;
        }


        

        ///Insertion Sort: insertion sort is an in-place sorting algorithm.
        ///This algorithm is one of the simplest algorithm with simple implementation
        ///Basically, Insertion sort is efficient for small data values
        ///Insertion sort is adaptive in nature, 
        ///i.e.it is appropriate for data sets which are already partially sorted
       ///Time complexity:  O(n2)
       ///space complexity : O(1)
        static int[] InsertionSort(int[] nums)
        {
            int tempKey; //create tempkey var

            int n = nums.Length; //array length           

            for (int i = 0; i < n-1; i++) //start from index 0 to n-1, last index
            {
                tempKey = nums[i];

                int j = i - 1; //current index

                // Move elements of arr[0..i-1], that are greater than key,
                // to one position ahead of their current position

                while (j >= 0 && nums[j] > tempKey)
                {
                    nums[j + 1] = nums[j]; //make next element our current element
                    j--;  //decrement current index, go backward since key is less than current, nums[j]
                }
                nums[j + 1] = tempKey; //assign next index element to the key
            }

            //return array
            return nums;
        }

       
        /// two sums: return indices of two numbers from array which when added equals the target
        public static int[] TwoNums(int[] nums, int target)
        {
            //get length of arr
            int n = nums.Length;
            int[] retArr = new int[2]; //must be of size 2, we need only 2 values
            for(int i = 0; i < n-1; i++) //checks current element
            {
                //check if is dup, jump
                if(nums[i] == nums[i + 1])
                {
                    continue; //skip, go to next
                }

                for(int j = i + 1; j < n; j++) //checks next element::inner loop
                {
                    if(nums[i] + nums[j] == target)
                    {
                        retArr[0] = i;
                        retArr[1] = j;
                        return retArr;
                    }
                }               
            }
            return retArr;
        }

        /// A binary gap within a positive integer N is any maximal 
        /// sequence of consecutive zeros that is surrounded by ones 
        /// at both ends in the binary representation of N.For example, 
        /// number 9 has binary representation 1001 and contains a binary gap of length 2.
        /// The number 529 has binary representation 1000010001 and contains two binary gaps:
        /// one of length 4 and one of length 3. The number 20 has binary representation 10100 
        /// and contains one binary gap of length 1. The number 15 has binary representation 1111
        /// and has no binary gaps.  
        /// below leetcode solution finds the maximum binary gaps

        public static int MaximumBinaryGap(int n)
        {
            //first convert the number into long int :: Int64
            long toI64 = Convert.ToInt64(n);

            //convert to binary string
            string binaryStr = Convert.ToString(toI64, 2);

            //convert to chars array
            char [] binaryChars = binaryStr.ToCharArray();

            //initial initializations
            int MaxLengthCounter = 0; //keeps record of max 0 counts
            int count = 0; //zero counter
            bool resetCounter = false; //reset and start counting again

            foreach (char c in binaryChars)
            {
                if (c == '1')
                {
                    if (MaxLengthCounter < count)
                    { 
                        MaxLengthCounter = count; 
                    }
                    count = 0;
                    resetCounter = true;
                }
                else
                {
                    if (resetCounter) 
                    {
                        count++;
                    }
                }
            }
            //return record of maximum zeros counter kept
            return MaxLengthCounter;
        }
        
        //maximum difference: diff between smaller element and largest elemnt of the array
        static int GetMaximumDifference(int[] nums)
        {

            int dif = int.MinValue; //initialize smallest possible difference

            int n = nums.Length;

            if (n == 0) { return dif; }

            int max_elem_record = nums[n - 1]; //keep maximum element, assume array is sorted in asc order

            // traverse the array from the right and keep track of the maximum element
            for (int i = n - 1; i >= 0; i--)
            {
                // update `max_elem_record` if the current element is greater than the maximum element
                if (nums[i] >= max_elem_record)
                {
                    max_elem_record = nums[i];
                }                
                else
                {
                    // if the current element is less than the maximum element, then update the difference 
                    dif = Math.Max(dif, max_elem_record - nums[i]);
                }
            }

            // return difference
            return dif;
        }

        public static int MaximumSortedAdjacentDiff(int[] nums)
        {
            int n = nums.Length;

            if (n < 2) { return 0; }

            // Find maximum and minimum elements in the array nums[]
            int maxVal = nums[0];
            int minVal = nums[0];
            for (int i = 1; i < n; i++) //don't confuse this, i MUST = 1 , when starting this loop
            {
                maxVal = Math.Max(maxVal, nums[i]);
                minVal = Math.Min(minVal, nums[i]);
            }

            // Arrays to store maximum and minimum values in n-1 buckets of differences.
            int[] maxBucket = new int[n - 1];
            int[] minBucket = new int[n - 1];

            maxBucket = maxBucket.Select(i => int.MinValue).ToArray();
            minBucket = minBucket.Select(i => int.MaxValue).ToArray();

            // Expected gap for every bucket.
            float expectedGap = (float)(maxVal - minVal) / (n - 1);

            // Traversing through array elements and
            // filling in appropriate bucket if bucket is empty. Else updating bucket values.
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == maxVal || nums[i] == minVal)
                {
                    continue;
                }

                // Find index of bucket.
                int index = (int)(Math.Round((nums[i] - minVal) / expectedGap));

                // Fill/Update maximum value of bucket
                if (maxBucket[index] == int.MinValue)
                {
                    maxBucket[index] = nums[i];
                }
                else
                {
                    maxBucket[index] = Math.Max(maxBucket[index], nums[i]);
                }

                // Fill/Update minimum value of bucket
                if (minBucket[index] == int.MaxValue)
                {
                    minBucket[index] = nums[i];
                }
                else
                {
                    minBucket[index] = Math.Min(minBucket[index], nums[i]);
                }
            }

            // Finding maximum difference between maximum value of previous bucket
            // minus minimum of current bucket.
            int prev_val = minVal;
            int max_gap = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (minBucket[i] == int.MaxValue)
                {
                    continue;
                }
                max_gap = Math.Max(max_gap, minBucket[i] - prev_val);
                prev_val = maxBucket[i];
            }
            max_gap = Math.Max(max_gap, maxVal -  prev_val);

            return max_gap;

        }

        /// string palindrome check using inbuild library      
        static bool StrPalindromeChecker(string str)
        {
            string stringOg, revrSed;
            stringOg = str;
            //get character arrays
            char[] ch = stringOg.ToCharArray();

            //then reverse character arrays
            Array.Reverse(ch);

            revrSed = new string(ch);

            bool b = stringOg.Equals(revrSed, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("" + stringOg + " is a Palindrome!");
                return true;              
            }
            else
            {
                Console.WriteLine(" " + stringOg + " is not a Palindrome!");
                return false;               
            }
        }

        ///string palindrome check without library
        static bool IsStrPalindrom(string str)
        {          
            string reverseStr = string.Empty; //initialize reverse string to empty on start

            //get string length
            int n = str.Length;

            //reverse the string, from the back, end position
            for (int i = n - 1; i >= 0; i--)
            {
                reverseStr += str[i];
            }

            if (str == reverseStr)
            {
                Console.WriteLine($"{str} is Palindrome!");
                return true;               
            }
            else
            {
                Console.WriteLine($"{str} is not Palindrome!!");
                return false;
            }
        }

        static bool IsIntegerPalindrome(int num)
        {
            int reminder, sum = 0, temp;
           
            temp = num; //init temp to the given number

            while (num > 0) //iterate
            {
                reminder = num % 10; //divide by 10 and get and record reminder

                //get sum var
                sum = (sum * 10) + reminder;

                num = num / 10;
            }

            if (temp == sum)
            {
                Console.Write("Number is Palindrome!");
                return true;
            }
            else
            {
                Console.Write("Number is not Palindrome!");
                return false;                
            }
                
        }
        //maximum product pair

        ///Given an integer array, find a pair with the maximum product in it.
        ///Each input can have multiple solutions.The output should match with either one of them.
        ///Input : [-10, -3, 5, 6, -2]
        ///Output: (-10, -3) or(-3, -10) or(5, 6) or(6, 5)
        ///Input : [-4, 3, 2, 7, -5]
        ///Output: (3, 7) or(7, 3)
        ///If no pair exists, the solution should return null.
        ///Input : [1]
        ///Output: null
        /// Time Complexity: O(nlog n)
        /// Auxiliary Space: O(1)

        static void MaxProductPair(int[] arr)
        {
            int n = arr.Length;

            // Sort the array first, if it's not sorted, assume the array is not sorted
            Array.Sort(arr);

            Console.WriteLine("sorted array: ");
            _printAnySortedArray(arr);

            if (n < 2)
            {
                Console.Write("no pair");
                return;
            }

            int num1, num2;
            //Math.Abs ==> to get non-negative numbers
            // Calculate product of two smallest numbers
            int sumSmall = Math.Abs(arr[0] * arr[1]);

            // Calculate product of two largest numbers
            int sumLarge= Math.Abs(arr[n - 1] * arr[n - 2]);

            // Print the pairs whose product is greater
            if (sumSmall > sumLarge)
            {
                num1 = arr[0];
                num2 = arr[1];
            }
            else
            {
                num1 = arr[n - 2];
                num2 = arr[n - 1];
            }
            Console.Write("Max product pair: " + "[" + num1 + "," + num2 + "]");
        }

        /// Given the array of integers nums, you will choose two different indices i and j 
        /// of that array. Return the maximum value of (nums[i]-1)*(nums[j]-1).
        /// Example 1:Input: nums = [3,4,5,2]
        /// Output: 12 
        /// Explanation: If you choose the indices i=1 and j=2 (indexed from 0), you will get the maximum value,
        /// that is, (nums[1]-1)*(nums[2]-1) = (4-1)*(5-1) = 3*4 = 12. 
        /// 
        public static int maxProduct(int[] nums)
        {
            int maxProduct = int.MinValue; 

            int n = nums.Length;

            Array.Sort(nums); //sort array first in asc order

            //i = 1, j = 2;
            //step back 1 position for each element chosen
            //e.g nums[n-1]-1 = --nums[n-1], nums[n-2]-1 = --nums[n-2]
            maxProduct = --nums[n - 1] * --nums[n - 2] ;
            
            return maxProduct;
        }


        // why Microsoft? - base answers on work culture:
        // 1 ). Growth Mindset- align my dreams / vision to fit in Microsoft's culture,
        // coz I'd like to grow careerwise ( Career Growth ) - boost my skills and experience through working
        // with world class team of developers, learn from each other, help make me better than how I am now.       
        // personal growth help take care of myself and others dependent on me.
        // 2 ). Diverse & Inclusive. I am open to learning and adopting to changes accordingly, take feedback from others and work
        // on them to become better, add quality in my work. 

        ///dynamic memory allocation in C/C++: done using malloc(), calloc(), free(), realloc()
        /// "malloc()": dynamically allocate a single large block of memory with the specified size.
        ///eg. p = (cast-type*)malloc(bytesize):: p = (int*) malloc(100 * sizeof(int));
        ///If space is insufficient, allocation fails and returns a NULL pointer.
        ///
        ///"calloc()" - “contiguous allocation” method in C is used to dynamically allocate the
        ///specified number of blocks of memory of specified type. 
        ///it is very much similar to malloc() but has two different points and these are:
        ///a. It initializes each block with a default value ‘0’.
        ///b. It has two parameters or arguments as compare to malloc().
        ///eg. ptr = (cast-type*)calloc(n, element-size);
        ///:: ptr = (float*) calloc(25, sizeof(float));
        ///This statement allocates contiguous space in memory for 25 elements each with the size of the float.

        ///“free()” method in C is used to dynamically de-allocate the memory. 
        ///The memory allocated using functions malloc() and calloc() 
        ///is not de-allocated on their own. Hence the free() method is used, 
        ///whenever the dynamic memory allocation takes place. 
        ///It helps to reduce wastage of memory by freeing it.
        ///eg: free(ptr)::ptr allocated before, above
        ///
        ///“realloc()” or “re-allocation” method in C is used to dynamically
        ///change the memory allocation of a previously allocated memory. 
        ///In other words, if the memory previously allocated with the help of 
        ///malloc or calloc is insufficient, realloc can be used to dynamically re-allocate memory. 
        ///eg ptr = realloc(ptr, newSize);



    }
}
