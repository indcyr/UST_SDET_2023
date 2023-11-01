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
        public void eg1()
        {
            List<string> courses = new List<string>();
            courses.Add("C Tutorial");
            courses.Add("C++ Tutorial");
            courses.Add("Java Tutorial");
            courses.Add("Web Tech");
            courses.Add("DBMS");
            courses.Add("UI Exp");

            //  var result = from c in courses where c.Equals("DBMS") select c;
            // var result = courses.Where(c => c.Equals("DBMS"));
            var result = courses.Where(c => c.Contains("Tutorial"));
            foreach (var c in result) {
            Console.WriteLine(c);
            }
        }
        public void eg2()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Ravi", "CSE"));
            students.Add(new Student(2, "Anu", "MCE"));
            students.Add(new Student(3, "Manu", "EEE"));
            students.Add(new Student(4, "Lilly", "ECE"));
            students.Add(new Student(5, "Unni", "AIE"));

            Student stud = (Student)students.FirstOrDefault(s => s.Id == 8);
            if(stud != null) { 
            Console.WriteLine("Student:"+ stud.Id + "" + stud.Name + "" + stud.Dept);
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            List<Student> stud1 =(List<Student>)students.FindAll(s=>s.Name == "Lilly" || s.Name == "Anu");
            //var stud = students.Where(s=> s.Id == 4);
            foreach (var s in stud1)
            {
                Console.WriteLine("Student :" +  s.Id + " " + s.Name + " " + s.Dept);
            }
            var result = students.OrderBy(s => s.Id).ThenBy(s => s.Name);
            foreach(var s in result)
            {
                Console.WriteLine(s.Name + " " + s.Id);
            }
            var result1  = students.ToLookup(s => s.Id);
            foreach (var s in result1)
            {
                Console.WriteLine(s.Key);
                foreach(var s2 in s)
                    Console.WriteLine(s2.Name+ "" +s2.Dept);
            }
        }
        public void SortingOrderBy()
        {
            ArrayList elements = new()
            {
                1,2,3,"Four",5,"Six"
            };
            var numbers = elements.OfType<int>();
            var strings = elements.OfType<string>();
            foreach (string str in strings)
                Console.WriteLine("String: " + str);
            foreach (int num in numbers)
                Console.WriteLine("Integer: " + num);
        }
    }
}
