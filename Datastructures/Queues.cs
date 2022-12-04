using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class Queues
    {      

        ///Priority Queue is an extension of the queue with the following properties: 
        ///Every item has a priority associated with it.
        ///An element with high priority is dequeued before an element with low priority.
        /// If two elements have the same priority, they are served according to their order in the queue.
        /// 
        /// A Binary Heap is a Binary Tree with the following properties:  
        /// It is a Complete Tree.This property of Binary Heap makes them suitable to be stored in an array.
        /// A Binary Heap is either Min Heap or Max Heap.
        /// In a Min Binary Heap, the key at the root must be minimum among all keys present in Binary Heap.
        /// The same property must be recursively true for all nodes in Binary Tree.
        /// Similarly, in a Max Binary Heap, the key at the root must be maximum among 
        /// all keys present in Binary Heap. The same property must be recursively true for all nodes in Binary Tree.
        /// Operation on Binary Heap
        ///  insert(p): Inserts a new element with priority p.
        ///  extractMax(): Extracts an element with maximum priority.
        ///  remove(i): Removes an element pointed by an iterator i.
        ///  getMax(): Returns an element with maximum priority.
        ///  changePriority(i, p): Changes the priority of an element pointed by i to p.
        ///
        

        ///How to implement priority-queue using array implementation of binary heap

        static int[] H = new int[50]; //initialize the binary heap array
        static int size = -1; //size of the priority queue

        // return the index of the parent node of a given node, i is the index
        int parentNode(int i)
        {
            return (i - 1) / 2;
        }

        // Function to return the index of the left child of the given node
         int leftChild(int i)
        {
            return (2 * i) + 1;
        }

        // Function to return the index of the right child of the given node
        int rightChild(int i)
        {
            return (2 * i) + 2;
        }

        // Function to shift up the node in order to maintain the heap property
         void shiftUp(int i)
        {
            while (i > 0 && H[parentNode(i)] < H[i])
            {
                // Swap parent and current node
                swap(parentNode(i), i);

                // Update i to parent of i
                i = parentNode(i);
            }
        }

        // Function to shift down the node in order to maintain the heap property
        void shiftDown(int i)
        {
            int maxIndex = i;

            // Left Child
            int l = leftChild(i);

            if (l <= size &&
            H[l] > H[maxIndex])
            {
                maxIndex = l;
            }

            // Right Child
            int r = rightChild(i);

            if (r <= size && H[r] > H[maxIndex])
            {
                maxIndex = r;
            }

            // If i not same as maxIndex
            if (i != maxIndex)
            {
                swap(i, maxIndex);
                shiftDown(maxIndex);
            }
        }

        // Function to insert a new element in the Binary Heap
         void insertToHeap(int elem)
        {
            size = size + 1;
            H[size] = elem;

            // Shift Up to maintain heap property
            shiftUp(size);
        }

        // Function to extract the element with maximum priority
         int extractMax()
        {
            int result = H[0];

            // Replace the value at the root with the last leaf
            H[0] = H[size];
            size = size - 1;

            // Shift down the replaced element to maintain the heap property
            shiftDown(0);
            return result;
        }

        // Function to change the priority of an element
         void changePriority(int i, int p)
        {
            int oldp = H[i];
            H[i] = p;

            if (p > oldp)
            {
                shiftUp(i);
            }
            else
            {
                shiftDown(i);
            }
        }

        // Function to get value of the current maximum element
        int getMax()
        {
            return H[0];
        }

        // Function to remove the element located at given index
        void Remove(int i)
        {
            H[i] = getMax() + 1;

            // Shift the node to the root of the heap
            shiftUp(i);

            // Extract the node
            extractMax();
        }
        void swap(int i, int j)
        {
            int temp = H[i];
            H[i] = H[j];
            H[j] = temp;
        }

        //create priority queue from an array

        public void _createPriorityQueue(int[] nums)
        {
            //sort the array first
            Array.Sort(nums);

            for(int i = 0; i < nums.Length; i++)
            {
                // Insert the element to the priority queue
                insertToHeap(nums[i]);                
            }
        }

        public void PriorityQueueOps(int[] arrs)
        {
            //create heap first
            _createPriorityQueue(arrs);

            int i = 0;

            // Priority queue before extracting max:: original queue
            Console.Write("My Priority Queue : ");
            while (i <= size)
            {
                Console.Write(H[i] + " ");
                i++;
            }

            Console.WriteLine();

            // Node with maximum priority
            Console.Write("Node with maximum priority : " + extractMax() + "\n");

            // Priority queue after extracting max
            Console.Write("Priority queue after extracting maximum : ");
            int j = 0;
            while (j <= size)
            {
                Console.Write(H[j] + " ");
                j++;
            }

            Console.WriteLine();

            // Change the priority of element present at index 2 to 49
            changePriority(2, 49);
            Console.Write("Priority queue after " +
            "priority change : ");
            int k = 0;
            while (k <= size)
            {
                Console.Write(H[k] + " ");
                k++;
            }

            Console.Write("\n");

            // Remove element at index 3
            Remove(3);
            Console.Write("Priority queue after removing the element : ");
            int l = 0;
            while (l <= size)
            {
                Console.Write(H[l] + " ");
                l++;
            }
        }





    }
}
