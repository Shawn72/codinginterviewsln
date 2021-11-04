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
            // minArrayOp();
            // _UpdateBits();
            ZeroMatrix();

            //below code should come at the bottom, make cmd not disappear
            Console.ReadLine();
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
            Arrays ar = new Arrays();
            int[] arr = { 1, -4, -3, 0, 9, -8 };
            int len = arr.Length;
            int minOp = ar.LeetCodeMinOperations(len); ;
            Console.WriteLine("minimum operations: "+ minOp);
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

       
    }
}
