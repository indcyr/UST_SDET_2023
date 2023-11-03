using DataStructures;

//CustomStack<int> stack = new CustomStack<int>(5);

//stack.Push(1);
//stack.Push(2);
//stack.Push(3);

//var topItem = stack.Peek();
//Console.WriteLine($"Top item: {topItem}");

//stack.Pop();
//stack.Pop();
//stack.Pop();
//stack.Pop(); // Trying to pop from an empty stack

//stack.Push(4);




//CustomQueue<int> queue = new CustomQueue<int>(5);

//queue.Enqueue(1);
//queue.Enqueue(2);
//queue.Enqueue(3);

//queue.Dequeue();
//queue.Dequeue();
//queue.Dequeue();
//queue.Dequeue(); // Trying to dequeue from an empty queue

//queue.Enqueue(4);
//queue.Enqueue(5);



//CustomLinkedList<int> linkedList = new CustomLinkedList<int>();

//linkedList.AddNode(1);
//linkedList.AddNode(2);
//linkedList.AddNode(3);

//linkedList.RemoveNode(2);
//linkedList.RemoveNode(4); // Trying to remove a non-existent node

//linkedList.DisplayList();


//Linear search

//int[] data = { 10, 25, 7, 42, 15, 30, 8, 50, 5 };

//      int target = 42;
//      int result = LinearSearch.Search(data, target);

//      if (result != -1)
//      {
//          Console.WriteLine($"Element {target} found at index {result}.");
//      }
//      else
//      {
//          Console.WriteLine($"Element {target} not found in the array.");
//      }

// Binary search

//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int target = 6;

//int result = BinarySearch.Search(arr, target);

//if (result != -1)
//{
//    Console.WriteLine($"Element {target} found at index {result}");
//}
//else
//{
//    Console.WriteLine($"Element {target} not found in the array");
//}



//BubbleSort


using DataStructures;

int[] arr = { 5, 1, 4, 2, 8 };



Console.WriteLine("Original Array:");
PrintArray(arr);

BubbleSort.Sort(arr);

Console.WriteLine("Sorted Array:");
PrintArray(arr);


static void PrintArray(int[] arr)
{
    foreach (var num in arr)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}
