//call the fucntions here

int[] nums =  { 2, 5, 4, 9, 6, 10, 7 };
Array.Sort(nums);
Console.WriteLine("sorted array: ");
_printAnySortedArray(nums);
int k = 2;
Console.WriteLine("kth largest: "+KthLargestNumber(nums, k));




//end line for the console output
Console.ReadLine();


///Implementations

//priority queues
//find kth largest
static int KthLargestNumber(int[] nums, int k)
{
    PriorityQueue<int, int> heap = new PriorityQueue<int, int>(); // PriorityQueue <element, priority>()

    foreach (int elem in nums)
    {
        heap.Enqueue(elem, elem); //this adds the nums to the heap queue

        if (heap.Count > k)
        {
            heap.Dequeue(); //remove elements if the heap size or count is > than given k position
        }
    }
    return heap.Dequeue();
}

///utility functions

void _printAnySortedArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}


