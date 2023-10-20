using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class StudentDetails : College
    {
        /*public StudentDetails(int rollNo, string? studName, string? city)
        {
            RollNon = rollNon;
            StudName = studName;
            City = city;
        }
        */
        public int RollNo {  get; set; }
        public string? StudName { get; set;}
        public string? City { get; set;}

        public void DisplayStudentDetails()
        {
            Console.WriteLine("Roll Num : {0} \n Name : {1} \n" + "City : {2}", RollNo, StudName, City);
        }
    }
}
