using Case_Study.ExceptionFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    public class Course : IEnrollable
    {

        public int CourseCode { get; set; }
        public string? Title { get; set; }
        public string? Instructor { get; set; }
        public List<Student> EnrolledStudents { get; set; } = new List<Student>();

        public void CourseRegistration(Student student, Course course)
        {
            EnrollementRecord enroll = new EnrollementRecord(student, course);
            int count = 10;
            if (count <= 10)
            {
                EnrollementRecord stud = EnrollementRecord.enrollementRecords.FirstOrDefault(s => s.Student.Name == student.Name);
                if (stud == null)
                {
                    EnrollementRecord.enrollementRecords.Add(enroll);
                }
                else
                {
                    
                    throw new EnrollementException("Student Already Exists");
                }
            }
            else
            {
                throw new EnrollementException("Course is Full");
            }
        }

        public void CourseWithdrawal(EnrollementRecord enrollrec)
        {
            EnrollementRecord stud = EnrollementRecord.enrollementRecords.FirstOrDefault(s => s.Student.StudentID == enrollrec.Student.StudentID);
            if (stud != null)
            {
                EnrollementRecord.enrollementRecords.Remove(stud);
            }
            else
            {
                throw new EnrollementException("Can't Find Student");
            }
        }
    }
    }    

