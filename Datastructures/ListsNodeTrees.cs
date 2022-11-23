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
            public Node(int d) //takes in integer data
            {
                data = d;
                prev = next = null;
            }
        }  

        public class NodesAndLinkedLists
        {
            public Node head, lhead; //lhead: linked list head

            //insert data at the front of the list
            internal void InsertFront(NodesAndLinkedLists singlyList, int new_data)
            {
                Node new_node = new Node(new_data);
                new_node.next = singlyList.head;
                singlyList.head = new_node;
            }

            //insert last
            internal void InsertLast(NodesAndLinkedLists singlyList, int new_data)
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

            internal Node GetLastNode(NodesAndLinkedLists singlyList)
            {
                Node temp = singlyList.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                return temp;
            }
            //delete node by key
            internal void DeleteNodebyKey(NodesAndLinkedLists singlyList, int key)
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
                        //add the value to the HashSet,...or hashmap
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

            /* construct a Balanced Binary Search Tree from a sorted array */
            public virtual Node _sortedArrayToBST(int[] arr, int start, int end)
            {
                //pass array, start index, end index

                /* Base Case */
                if (start > end) return null;


                /* Get the middle element and make it root */
                int mid = (start + end) / 2;
                Node node = new Node(arr[mid]); //initialize the node

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
                Console.Write(node.data + " ");
                preOrder(node.prev);
                preOrder(node.next);
            }

            //leetCode solution
            public virtual Node SortedArrayToBST(int[] nums)
            {
                int n = nums.Length;

                int start = 0;
                int end = n - 1;

                /* Base Case */
                if (start > end) return null;

                /* Get the middle element and make it root */
                int mid = (start + end) / 2;
                Node node = new Node(nums[mid]);

                int[] leftArr = new int[mid];
                int[] rightArr = new int[n - mid];
                Array.Copy(nums, start, leftArr, 0, mid);
                rightArr = nums.Skip(leftArr.Length).ToArray();

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
                Node node = new Node(arr[mid]);
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
                    Console.Write(node.data + " ");
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

            //Time Complexity: O(n) on average (assuming that hash table access time is O(1) on average).

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


    }
}
