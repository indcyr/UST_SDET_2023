using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class CustomStack<T>
    {
        private T[] stackArray;
        private int top;
        private int maxSize;

        public CustomStack(int size)
        {
            maxSize = size;
            stackArray = new T[maxSize];
            top = -1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == maxSize - 1;
        }

        public void Push(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full. Cannot push.");
                return;
            }
            stackArray[++top] = item;
            Console.WriteLine($"Pushed: {item}");
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty. Cannot pop.");
                return default(T);
            }
            T poppedItem = stackArray[top--];
            Console.WriteLine($"Popped: {poppedItem}");
            return poppedItem;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty. Cannot peek.");
                return default(T);
            }
            return stackArray[top];
        }

    }
}
