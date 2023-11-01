using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQEx
    {
        public void ExampleOne()
        {
            List<string> courses = new List<string>();
            courses.Add("C Tutorial");
            courses.Add("Java Tutorial");
            courses.Add("C# Tutorial");
            courses.Add("C++ Tutorial");
            courses.Add("DBMS");
            courses.Add("UI");

            //var result = from c in courses
            //             where c.Equals("DBMS")   //query Syntax
            //             select c;


            // var result = courses.Where(c =>c.Contains("Tutorial"));  //method syntax

            var result = courses.Where(c => c.EndsWith("l"));
            foreach (var r in result)
            {
                Console.WriteLine(r);

            }


        }

        public void ExampleTwo()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Adhi", 24));
            students.Add(new Student(2, "Hari", 26));
            students.Add(new Student(3, "Abhi", 25));
            students.Add(new Student(4, "Afsal", 23));

            var stud = students.Where(s => s.StudentId == 1);
            foreach (var item in stud)
            {
                Console.WriteLine(item.StudentId + " " + item.StudentName + " " + item.Age);
            }



            Student? stud2 = students.FirstOrDefault(s => s.StudentId == 2);
            if (stud2 != null)
            {
                Console.WriteLine(stud2.StudentId + " " + stud2.StudentName + " " + stud2.Age);

            }

            Console.WriteLine("Greater than 3");

            List<Student> stud1 = students.FindAll(s => s.StudentId >= 3);
            foreach (Student item in stud1)
            {
                Console.WriteLine(item.StudentId + " " + item.StudentName + " " + item.Age);
            }

        }

        public void filteringofType()
        {
            ArrayList elements = new ArrayList();
            elements.Add(1);
            elements.Add(2);
            elements.Add("Adhi");


            var num = elements.OfType<int>();
            var strings = elements.OfType<string>();
            foreach (string str in strings)
            {
                Console.WriteLine("String :" + str);
            }
            foreach (int item in num)
            {
                Console.WriteLine("Integer: " + item);
            }

        }



        public void SortOrderBy()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Adhi", 24));
            students.Add(new Student(2, "Amal", 26));
            students.Add(new Student(3, "Abhi", 25));
            students.Add(new Student(4, "Afsal", 23));

            //var result = students.OrderBy(s => s.StudentName).ThenBy(s=> s.Age);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.StudentId+  " "+item.StudentName + " " + item.Age);
            //}

            var result1 = students.ToLookup(s => s.StudentName);
            foreach (var s in result1)
            {
                Console.WriteLine(s.Key);

                foreach (var x in s)
                {

                    Console.WriteLine(x.StudentId + " " + x.Age);
                }
            }

        }
    }
}
