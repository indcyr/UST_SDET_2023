﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Student
    {
        public Student(int studentId, string? studentName, int age)
        {
            StudentId = studentId;
            StudentName = studentName;
            Age = age;
        }

        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public int Age { get; set; }
    }
}
