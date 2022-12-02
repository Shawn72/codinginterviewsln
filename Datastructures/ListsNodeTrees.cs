using System;
using System.Collections.Generic;
using System.Linq;

namespace Datastructures
{
    public class ListsNodeTrees
    {
        // node class to use with Binary trees,  linked list, doubly linked list : general node class
        public class Node
        {
            public int data;
            public Node next, prev; //can rep left, right

            //create an empty list as below::
            //use of constructor call to minimize mem allocations, use few lines of code
            public Node(int d) //takes in integer data
            {
                data = d;
                prev = next = null;
            }
        }  

        //implementations of linked lists and queues
        public class NodesAndLinkedLists
        {
            public Node head, lhead; //lhead: linked list head

            //insert data at the front of the list
            internal void InsertFront(int new_data)
            {
                Node new_node = new Node(new_data);
                new_node.next = head;
                head = new_node;
            }

            //util to creat a linked list from array
            public Node _ConvertArrayToList( int[] arr )
            {
                int n = arr.Length;

                Node head = null;

                for (int i = 0; i < n; i++)
                    head = _InsertNode(head, arr[i]);
                return head;
            }

            //insert a node, variation, return the head, or the list
            static Node _InsertNode(Node head, int item)
            {
                //use constructor
                Node ptr, temp = new Node(item);              

                temp.data = item;
                temp.next = null;

                if (head == null)
                    head = temp;
                else
                {
                    ptr = head;
                    while (ptr.next != null)
                        ptr = ptr.next;
                    ptr.next = temp;
                }
                return head;
            }

            //insert last
            internal void InsertLast(int new_data)
            {
                Node new_node = new Node(new_data);
                if (head == null)
                {
                    head = new_node;
                    return;
                }
                //get last node first,..then insert
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            internal Node GetLastNode()
            {
                Node temp = head;
                while (temp.next != null) //terminating base: when temp.next == null;
                {
                    temp = temp.next;
                }
                return temp;
            }
            //delete node by key
            internal void DeleteNodebyKey(int key)
            {
                Node temp = head;
                Node prev = null;
                if (temp != null && temp.data == key)
                {
                    head = temp.next;
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
                if (head == null) return;

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

            /* print linked list helper */
            public void _printList()
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + "->");
                    temp = temp.next; //point temp to the next data
                }
                Console.WriteLine();
            }

            // remove duplicates from an unsorted linked list::use HashMaps, hashsets
            public void removeDuplicateFromList(Node head)
            {
                // Hash to store already seen values
                var hs = new HashSet<int>();

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
                        //add the value to the HashSet,...or hashmap
                        hs.Add(curval);
                        prev = current;
                    }
                    //base condition: when current becomes null,,...or when next == null
                    current = current.next;
                }
            }

            // print nodes in a given linked list
            public void _printNode(Node head)
            {
                while (head != null)
                {
                    Console.Write(head.data + " --> ");
                    head = head.next;
                }
            }

            // find kth element
            /* get the nth node from the last of a linked list */
            //Time Complexity: O(n) where n is the length of linked list. 
            public void _printKthFromLast(int n)
            {
                // find n-th position from last             

                int len = 0;
                Node temp = head;

                // a) count the number of nodes in Linked List 
                while (temp != null)
                {
                    temp = temp.next;
                    len++;
                }

                // check if value of n is not more than length of the linked list 
                if (len < n)
                {
                    Console.WriteLine("position " + n + " not available in the list");
                    return;
                }

                temp = head;

                // b) get the (len-n+1)th node from the beginning 
                for (int i = 1; i < len - n + 1; i++)
                    temp = temp.next;

                Console.WriteLine(temp.data);
            }

            /* construct a Balanced Binary Search Tree from a sorted array:: using recursion */
            public virtual Node _sortedArrayToBST(int[] arr, int start, int end)
            {
                //pass array, start index, end index

                /* Base Case */
                if (start > end) return null;


                /* Get the middle element and make it root */
                int mid = (start + end) / 2;

                Node node = new Node(arr[mid]); //initialize the node ,point to the middle element

                /* Recursively construct the left subtree and make it left child of root */
                node.prev = _sortedArrayToBST(arr, start, mid - 1); //prev::rep left node             

                /* Recursively construct the right subtree and make it right child of root */
                node.next = _sortedArrayToBST(arr, mid + 1, end); //next rep right node

                return node;
            }

            /*  print preorder traversal of BST */
            public virtual void preOrder(Node node)
            {
                if (node == null) return;
                Console.Write(node.data + "->");
                preOrder(node.prev);
                preOrder(node.next);
            }

            //leetCode solution
            public virtual Node SortedArrayToBST(int[] nums)
            {
                int n = nums.Length;

                int start = 0, end = n - 1;

                /* Base Case */
                if (start > end) return null;

                /* Get the middle element and make it root */
                int mid = (start + end) / 2;

                Node node = new Node(nums[mid]);

                /* Recursively construct the left subtree and make it left child of root */
                node.prev = _sortedArrayToBST(nums, start, mid - 1); //prev::rep left node

                /* Recursively construct the right subtree and make it right child of root */
                node.next = _sortedArrayToBST(nums, mid + 1, end); //next rep right node

                return node;
            }

            //create BST with minimal height       
            Node _MinimalHeightBST(int[] arr, int start, int end)
            {
                if (end < start) return null;
                int mid = (start + end) / 2;
                Node node = new Node(arr[mid]); //root node element
                node.prev = _MinimalHeightBST(arr, start, mid - 1);
                node.next = _MinimalHeightBST(arr, mid + 1, end);
                return node;
            }
           
            //implementation
            public Node createMinimalBST(int[] array)
            {
                return _MinimalHeightBST(array, 0, array.Length - 1);
            }

            /* A utility function that returns count of nodes in a given Linked List */
            int countLnkNodes(Node head)
            {
                int count = 0;
                Node temp = head;
                while (temp != null)
                {
                    temp = temp.next;
                    count++;
                }
                return count;
            }

            /* insert a node at the beginning of the Doubly Linked List */
            public void pushLnkNode(object new_data) //int values
            {
                /* allocate node */

                Node new_node = new Node(Convert.ToInt32(new_data));

                /* since we are adding at the beginning,
                prev is always NULL */
                new_node.prev = null;

                /* link the old list off the new node */
                new_node.next = lhead;

                /* change prev of head node to new node */
                if (lhead != null)
                    lhead.prev = new_node;

                /* move the head to point to the new node */
                lhead = new_node;
            }

            /* print nodes in a given linked list */
            public void _printLnkList(Node node)
            {
                while (node != null)
                {
                    Console.Write(node.data + "->");
                    node = node.next;
                }
            }

            /* count the number of nodes in Linked List and then call sortedListToBSTR() to construct BST */
            public Node sortedListToBST()
            {
                /*Count the number of nodes in Linked List */
                int n = countLnkNodes(lhead);

                /* Construct BST */
                return sortedListToBSTRec(n);
            }

            /* construct balanced BST and returns root of it. n: is the No. of nodes in the Doubly Linked List */
            public Node sortedListToBSTRec(int n)
            {
                /* Base Case */
                if (n <= 0)
                    return null;

                // binary tree node (Node)
                // LinkedNode (LnkMode)

                /* Recursively construct the left subtree */
                Node left = sortedListToBSTRec(n / 2);

                /* head_ref now refers to middle node,
                make middle node as root of BST*/
                Node root = new Node(lhead.data);

                // Set pointer to left subtree
                root.prev = left;

                /* Change head pointer of Linked List for parent recursive calls */
                lhead = lhead.next;

                /* Recursively construct the right subtree and link it with root. The number of
                nodes in right subtree is total nodes - nodes in left subtree - 1 (for root) */

                root.next = sortedListToBSTRec(n - n / 2 - 1);

                return root;
            }

            /* print preorder traversal of BST */
            public void preOrderLnk(Node node)
            {
                if (node == null)
                    return;
                Console.Write(node.data + " ");
                preOrderLnk(node.prev);
                preOrderLnk(node.next);
            }

            /* Returns true if binary tree with root as root is height-balanced */
            public virtual bool isBalanced(Node node)
            {
                int lh; // for height of left subtree

                int rh; // for height of right subtree

                /* If tree is empty then return true */
                if (node == null) return true; 

                /* Get the height of left and right sub trees */
                lh = height(node.prev);
                rh = height(node.next);

                //prev: left, next: right
                if (Math.Abs(lh - rh) <= 1 && isBalanced(node.prev)
                    && isBalanced(node.next))
                {
                    return true;
                }

                /* If it reaches here then tree is not height-balanced */
                return false;
            }

          
            /* The function Compute the "height" of a tree. Height is the
                number of nodes along the longest path from the root node
                down to the farthest leaf node.*/
            public virtual int height(Node node)
            {
                /* base case tree is empty */
                if (node == null)return 0;             

                /* If tree is not empty then height = 1 + max of left
                height and right heights */
                return 1 + Math.Max(height(node.prev), height(node.next));
            }

            /*maximum depth of a tree -- the number of
              nodes along the longest path from the root node down to the farthest leaf node.*/
            public int maximumDepth(Node node)
            {
                //Time Complexity: O(n), n: number of nodes
                if (node == null)
                    return 0;
                else
                {
                    /* calculate the depth of each subtree */
                    int leftDepth = maximumDepth(node.prev);
                    int rightDepth = maximumDepth(node.next);
                   return  Math.Max(leftDepth, rightDepth) + 1;
                }
            }

            //get value of Kth element implementation
            public void _GetKthElementofLinkedList(int n)
            {
                NodesAndLinkedLists llist = new NodesAndLinkedLists();
                llist._pushtoNode(25);
                llist._pushtoNode(40);
                llist._pushtoNode(18);
                llist._pushtoNode(32);

                //print list
                Console.WriteLine("Elements list:");
                llist._printList();
                Console.WriteLine("\n");

                Console.WriteLine("position " + n + " from last: ");
                llist._printKthFromLast(n);
            }

            public void MakeCircularListUsingPushNode(Node head)
            {
                Node mhead = head;
                head.next = mhead;//make it circular               
            }

            /// Circular Linked Lists: A linked list is called circular 
            /// if it is not NULL-terminated and all nodes are connected 
            /// in the form of a cycle.

            ///leetcode solution
            public bool HasCycle(Node head)
            {
                if (head == null) return true;//an empty list is assumed circular always

                //initialize the current node, and next node
                Node curr = head;
                Node nxtNode = head.next;

                //implement a while  loop::: iteration            
                while (curr != nxtNode)
                {
                    //check, handle if not a cycle
                    if (nxtNode == null || nxtNode.next == null)
                    {
                        //reached the end and no coming back to start hence not a cycle
                        return false;
                    }
                    curr = curr.next;
                    nxtNode = nxtNode.next.next;
                }
                return curr == nxtNode; //is a cycle       
            }

            //check if a linked list is circular
            /*This function returns true if given linked list is circular, else false. */
            public bool linkedListIsCircular(Node head)
            {
                // master the steps
                // 1. An empty linked list is circular - assume that always
                if (head == null) return true;

                // 2.  Next of head
                Node node = head.next; //current node

                // 3.  This loop would stop in both cases
                // (1) If Circular (2) Not circular
                while (node != null && node != head)
                    node = node.next;

                // 4.If loop stopped because of circular condition:
                // current node == head, we r back at start , hence it's circular
                return node == head;
            }

            //making a linked list circular
            public void MakeListCircular()
            {                
                // insert items in the list nodes
                Node head = new Node(10); 
                head.next = new Node(24); 
                head.next.next = new Node(32); 
                head.next.next.next = new Node(47);

                Console.WriteLine("Is the linked list circular?: ");

                Console.Write(HasCycle(head) ? "Yes\n" :  "No\n");

                // Make the linked list circular: assign final next to head node
                head.next.next.next.next = head;

                Console.WriteLine("Is the linked list circular now?: ");

                Console.Write(HasCycle(head) ? "Yes\n" :  "No\n");               
            }

            //insert into a sorted circular linked list::to be implemented later

            /// Time Complexity: O(M+N), At every call of recursion, 
            /// M: length of listOne, N: length of listTwo
            /// we are adding one node to the output.
            /// Space Complexity: O(M+N), Stack space will be used in recursion.
            
            //merge two linked list using recursion
            public Node mergeTwoLists(Node listOne, Node listTwo)
            {
                // Check if heads of the lists are null
                if (listOne == null || listTwo == null)
                    return listOne == null ? listTwo : listOne;

                //check the two lists root nodes and compare
                if (listOne.data > listTwo.data)
                {
                    //using swap to swap two lists
                    Node temp = listOne;
                    listOne = listTwo;
                    listTwo = temp;
                }

                //merge list two into list one
                listOne.next = mergeTwoLists(listOne.next, listTwo);
                return listOne;                
            }
        }

        public static void _LinkedListOps()
        {
            //Time Complexity: O(n) where n is the number of nodes in the given linked list.

            NodesAndLinkedLists _list = new NodesAndLinkedLists();
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
            // Time Complexity: O(n) on average
            // assuming that hash table access time is O(1) on average.

            NodesAndLinkedLists _list = new NodesAndLinkedLists();
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

        ///doubly linked list implementation
        
        //node structure:: without using constructor call
        public class DLLNode
        {
            public int data;
            public DLLNode next;
            public DLLNode prev;
        }

        //implementation of dll list
        public class DoubleLinkedList
        {
            public DLLNode head, tail; //inititalize head and tail           

            //constructor to create an empty LinkedList
            public DoubleLinkedList()
            {
                head = null;
            }

            //create dll list
            public DoubleLinkedList CreateDoulblyLinkedList()
            {
                //create and initialize an empty LinkedList
                DoubleLinkedList _dlist = new DoubleLinkedList();

                //Add first node.
                DLLNode nodeOne = new DLLNode();
                nodeOne.data = 15;
                nodeOne.next = null;
                nodeOne.prev = null;
                //linking with head node
                _dlist.head = nodeOne;

                //Add second node.
                DLLNode nodeTwo = new DLLNode();
                nodeTwo.data = 20;
                nodeTwo.next = null;
                //linking with first node
                nodeTwo.prev = nodeOne; //make prev of node 2 point to node 1
                nodeOne.next = nodeTwo; //next of node 1 point to node 2

                //Add third node.
                DLLNode nodeThree = new DLLNode();
                nodeThree.data = 25;
                nodeThree.next = null;
                //linking with second node
                nodeThree.prev = nodeTwo; //make prev of node 3 point to node 2
                nodeTwo.next = nodeThree; //next of node 2 point to node 3

                // return the list created
                return _dlist;
            }

            //for printing the list, takes in doubly linked list created as the parameter
            public void _printDoublyLinkedList(DoubleLinkedList dList)
            {               
                var list = dList.head;

                if (list != null)
                {
                    Console.Write("The list contains: ");
                    while (list != null)
                    {
                        Console.Write(list.data + "-->");
                        list = list.next;
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The list is empty!");
                }
            }
        }

        //using constructor call method to insert
        public void dll_insertAtHead(int value)
        {
            Node head = null; // declaring an empty doubly linked list

            Node node = new Node(value);//insert value

            node.next = head;

            if (head != null) 
            {
                head.prev = node;
            }
            head = node;
        }

        public void dll_insertAtTail(int value)
        {
            Node head = null; // declaring an empty doubly linked list

            if (head == null)
            {
                dll_insertAtHead(value);
                return;
            }

            Node node = new Node(value);
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
            node.prev = temp;
        }
             



        ///drawbacks of Singly LL. A node deletion in Singly LL cannot be removed 
        ///unless we know the pointer of its predecessor, 
        ///whereas, in doubly LL, we can delete a node even if 
        ///we do not have the address of predecessor. 
        ///complexities for linked list ops
        ///Time complexity: O(n) , n::number of nodes
        ///Space Complexity: O(1)


    }
}
