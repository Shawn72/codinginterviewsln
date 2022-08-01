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

       
            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };

            // SortArray(arr);        


            //print leetcode sorted array
            // Console.WriteLine("my sorted array: " +ArrayPrintHelper(SortMeArray(arr)));

            //AbstrctClsTest();

            // string[] wrdarr = { "the", "dog", "got", "the" , "bone"};         
            //MyWordCounter(wrdarr);

            Reshape("mungu   ni mwema ii" , 3);

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

            //convert interger back to binary string
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
                a = a ^ b;

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
            else
                return AddMe(m ^ n, (m & n) << 1);
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
                YearofRegistration = "2021"
            };

            var newVehicle = new Vehicle();
            newVehicle = vehicle;

            newVehicle.Owner = "Mary"; //new owner is assigned, so Bob is overwritten
            newVehicle.YearofRegistration = "2021";

            Console.WriteLine("properties of vehicle, Owner:"+vehicle.Owner+" YoM: "+vehicle.YearofRegistration);
        }

        //string occurance
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
            //n = number of characters in each line
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




    }
}
