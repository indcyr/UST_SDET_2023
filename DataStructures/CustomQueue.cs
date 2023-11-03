using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class CustomQueue<T>
    {
        private T[] queueArray;
        private int front;
        private int rear;
        private int maxSize;

        public CustomQueue(int size)
        {
            maxSize = size;
            queueArray = new T[maxSize];
            front = -1;
            rear = -1;
        }

        public bool IsEmpty()
        {
            return front == -1;
        }

        public bool IsFull()
        {
            return (rear == maxSize - 1 && front == 0) || (rear + 1 == front);
        }

        public void Enqueue(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full. Cannot enqueue.");
                return;
            }
            if (rear == maxSize - 1)
            {
                rear = 0;
            }
            else
            {
                rear++;
            }
            queueArray[rear] = item;

            if (front == -1)
            {
                front = 0;
            }
            Console.WriteLine($"Enqueued: {item}");
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty. Cannot dequeue.");
                return default(T);
            }

            T dequeuedItem = queueArray[front];

            if (front == rear)
            {
                front = rear = -1;
            }
            else if (front == maxSize - 1)
            {
                front = 0;
            }
            else
            {
                front++;
            }
            Console.WriteLine($"Dequeued: {dequeuedItem}");
            return dequeuedItem;
        }
    }
    
    
}
