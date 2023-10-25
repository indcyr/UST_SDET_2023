using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_work
{
    internal class NGC
    {
        public void ArrayListHandling()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add(30);

            //Console.WriteLine(arrayList);
            
            arrayList.Add("AA");
            arrayList.Add(true);
            arrayList.Add(false);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Reverse();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.RemoveAt(3);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            //arrayList.Clear();

            Console.WriteLine(arrayList.IndexOf(20));
            Console.WriteLine(arrayList.Contains(10));
            
;        }
        public void StackHandling()
        {
            Stack st = new Stack();
            st.Push(10);
            st.Push(20);
            st.Push(30);
            st.Push("GG");
            st.Push(12.09);
            st.Push(66);
            st.Push(99);


            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(st.Pop());
            foreach(var item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(st.Peek());
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count : " + st.Count);

        }
        public void QueueHandling()
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue("GG");
            q.Enqueue(12.09);
            q.Enqueue(66);
            q.Enqueue(99);


            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(q.Dequeue());
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(q.Peek());
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count : " + q.Count);

        }
        public void HThandling()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, 10);
            ht.Add(2, 20);  
            ht.Add(3, 30);
            ht.Add("3", "AA");
            ht.Add(4, "BB");

            foreach (var item in ht)
            {
                Console.WriteLine(item);
            }
            ht.Remove(3);
            foreach (var item in ht)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(ht.ContainsKey("6"));
            
            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count : " + ht.Count);

        }
        public void SLHandling()
        {
            SortedList sl = new SortedList();
            sl.Add(3, 10);
            sl.Add(4, "AA");
            sl.Add(1, 30);
            sl.Add(2, 40);




            foreach (var item in sl)
            {
                Console.WriteLine(item);
            }
        }

       
    }
}
