using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  
        class Node<T>
        {
            public T Data { get; set; }
            public Node<T> Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }
        internal class CustomLinkedList<T>
        {
            private Node<T> head;

            public CustomLinkedList()
            {
                head = null;
            }

            public bool IsEmpty()
            {
                return head == null;
            }

            public void AddNode(T data)
            {
                var newNode = new Node<T>(data);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    var current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }
                Console.WriteLine($"Added: {data}");
            }

            public bool RemoveNode(T data)
            {
                if (IsEmpty())
                {
                    Console.WriteLine("List is empty. Cannot remove.");
                    return false;
                }

                if (head.Data.Equals(data))
                {
                    head = head.Next;
                    Console.WriteLine($"Removed: {data}");
                    return true;
                }

                var current = head;
                while (current.Next != null)
                {
                    if (current.Next.Data.Equals(data))
                    {
                        current.Next = current.Next.Next;
                        Console.WriteLine($"Removed: {data}");
                        return true;
                    }
                    current = current.Next;
                }
                Console.WriteLine($"Data not found: {data}");
                return false;
            }

            public void DisplayList()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("List is empty.");
                    return;
                }

                var current = head;
                Console.Write("List: ");
                while (current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Next;
                }
                Console.WriteLine();
            }

        }
    
}
