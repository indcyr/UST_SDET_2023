using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    
    internal class Employee :  Person, IDisplayable
    {
        public Employee(int empid,string? firstName, string? lastName, int age) : base(firstName, lastName, age)
        {
            EmpId = empid;
            
        }
        public int EmpId { get; set; }

       

        public void DisplayInfo()
        {
            Console.WriteLine("Full Name: {0} {1} \n Age: {2}",FirstName, LastName, Age);
        }

        
    }
}
