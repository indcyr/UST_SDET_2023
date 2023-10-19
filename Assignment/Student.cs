using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Student
    {
        public string name;
        public double grade1,grade2,grade3;

        public Student(string name, int grade1, int grade2, int grade3)
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

    }
}
