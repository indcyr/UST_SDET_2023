using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Assignment
{
    class Student
    {
        private string? name;
        private int[] marks = new int[3];
        private string grade;

        public Student(string? name, int[] marks, string grade)
        {
            this.Name = name;
            this.Marks = marks;
            this.Grade = grade;
        }

        public string? Name { get => name; set => name = value; }
        public int[] Marks { get => marks; set => marks = value; }
        public string Grade { get => grade; set => grade = value; }

        public double CalculateAverage()
        {
            double average = Marks.Average();
            return average;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine("Student Name : " + Name);
            Console.WriteLine("Grade :" + Grade);
            int i = 1;
            int total = 0;
            foreach (int mark in Marks) 
            {
                Console.WriteLine("Marks{0}: {1} ", i++, mark);
                total += mark;
            }
            Console.WriteLine("Total marks : " + total);
            Console.WriteLine();
        }
        public void GetMarksSummary()
        {
            int high = marks[0];
            int low = marks[0];
            foreach (int mark in Marks)
            {
                if(mark > high)
                    high = mark;
                if(mark < low) low = mark;
            }
            Console.WriteLine("Highest :" + high);
            Console.WriteLine("Lowest : " + low);
            Console.WriteLine();
        }

        /*public Student(string name, int grade1, int grade2, int grade3)
        {
            this.name = name;
            this.grade1 = grade1;
            this.grade2 = grade2;
            this.grade3 = grade3;
        }
        public double CalculateAverage()
        {
            double avg = 0;
            avg = (grade1 + grade2 + grade3)/3;
            return avg;
        }
        */
    }
}
