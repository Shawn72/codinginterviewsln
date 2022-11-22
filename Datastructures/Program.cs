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
        public static Arrays arrys = new Arrays();
        public static Matrix mtrx = new Matrix();
        public static BitsManipulation bt = new BitsManipulation();
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

            //graphs
            // _GraphCanBeConnected();
            //  BinarySearchTree();
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

            // int[] testArr = { 5, 6, 0, 4, 6, 0, 9, 0, 8, 10, 0, 0 };
            // PushAllZerosToEnd(testArr);

            // AddWOOperator(5, 10);
            // var sum =  AddMe(5, 10);
            // Console.WriteLine("sum is: " + sum);


            //int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };
            // SortArray(arr);        


            //print leetcode sorted array
            // Console.WriteLine("my sorted array: " +ArrayPrintHelper(SortMeArray(arr)));

            //AbstrctClsTest();

            // string[] wrdarr = { "the", "dog", "got", "the" , "bone"};         
            //MyWordCounter(wrdarr);

            //Reshape("mungu   ni mwema ii" , 3);

            //CallSealedClass();

            //Console.WriteLine("Is Unique: " +arrys.UniqueChar("mbuUvi") );

            //int[] arr = { 2, 1, 5, 1, 2, 2, 2 };
            // Console.WriteLine("Minimal Large Sum: "+MinMaxDivisionSolution(3, 5, arr));


            //int[] nums = { 5, 2, 3, 1 };
            //var sortedNums = Merge_SortArray(nums);
            //_printMergeSort(sortedNums);

            // int[] a = { 1, 3, 7, 9, 9 }; int[] b = { 5, 6, 8, 9, 10 };
            // Console.WriteLine("size of non-overlapping set: " + GreedyNonOverlappingSolution(a, b));

            //int[] arr = { 1, 3, 4, 3, 5, 7 };
            // Console.WriteLine("Is the array unique: " + UniqueOccurrenceOfElement(arr));

            int[] arr = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
            int n = arr.Length; //length of the array
            quickSort(arr, 0, n - 1);
            Console.Write("Sorted array: ");
            _printQuickSortedArray(arr);


            //below code should come at the bottom, make cmd not disappear
            Console.ReadLine();
        }


        // use Partitioning the array: why i used it, is simple ,dont require too much writing, fast to implement
        // use a 0 as a pivot, see non 0 element and swap it going left

        //Complexity Analysis:
        //Time Complexity: O(N)
        //Auxiliary Space: O(1)
        static void PushAllZerosToEnd(int [] arr)
        {
            int n = arr.Length; // array length
            int j = 0; // our pivot element
            for (int i = 0; i < n; i++) //traverse the array
            {
                if (arr[i] != 0)
                {
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
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

        static void CatsArrtoList() {
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
         
            int remainder;
            string binary = string.Empty;

            //convert integer back to binary string
            while (m > 0)
            {
                remainder = m % 2;
                m /= 2;
                binary = remainder.ToString() + binary;
            }

            return binary;
        }

        static void countFlippedBits() {
            int a = 12, b = 18;
            Console.WriteLine("bits to flip: " + bt.FlippedCount(a, b));
        }

        static void _NextSmallestorLargest() {

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

        //Binary Serach Algorith: MinMaxDivision
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
        //Time Complexity: O(nlogn )
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

            for (int k = low; k <= high; k++)
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
        //complexity: O(n log n)
        // A utility function to swap two elements
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

            // Index of smaller element and indicates the right position of pivot found so far
            int i = (low - 1);

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
                // pi is partitioning index, arr[p]
                // is now at right place
                int pi = arr_partitioner(arr, startingindex, endingindex);

                // Separately sort elements before partition and after partition
                quickSort(arr, startingindex, pi - 1);
                quickSort(arr, pi + 1, endingindex);
            }
        }

        // print sorted array
        static void _printQuickSortedArray(int[] arr)
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

        ///hashmaps, hashsets, dictionaries
        public static bool UniqueOccurrenceOfElement(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return true;

            var lenOfArr = arr.Length;

            //initialize a dictionary to hold on the key pair values
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

        // why microsoft? - work culture: Growth Mindset- align my dreams / vision to fit in Microsoft's culture,
        // coz I'd like to grow careerwise ( Career Growth ) - boost my skills and experience through working
        // with world class team of developers, learn from each other, help make me better than how I am now.       
        // personal growth help take care of myself and others dependent on me.



    }
}
