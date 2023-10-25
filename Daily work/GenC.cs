using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_work
{
    internal class GenC
    {
        public void ListHandling()
        {
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Add(50);
            numbers.Add(60);

            //Console.WriteLine(arrayList);

           
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Reverse();
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.RemoveAt(1);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            //arrayList.Clear();

            Console.WriteLine(numbers.IndexOf(10));
            Console.WriteLine(numbers.Contains(20));

        }
        public void DictHandling()
        {
            Dictionary<int,string> dict = new Dictionary<int,string>();

            dict.Add(1, "10");
            dict.Add(2, "20");
            dict.Add(3, "30");
            dict.Add(4, "40");
            dict.Add(5, "AA");

            foreach(var item in dict)
            {
                Console.WriteLine(item);
            }
            dict.Remove(3);
            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(dict.ContainsKey(4));

            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in dict.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count : " + dict.Count);
        }
        public void SLHandling()
        {
            SortedDictionary<int, string> s = new SortedDictionary<int, string>();
            s.Add(3, "10");
            s.Add(2, "20");
            s.Add(4, "40");
            s.Add(1, "70");

            foreach(var item in s)
            {
                Console.WriteLine(item);
            }


        }
    }
}
