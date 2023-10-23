using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Person
    {
        private int age;
        public Person(string? firstName, string? lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

      
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get => age; set {
                if (value >= 18 && value <= 100)
                    age = value;
                else Console.WriteLine("Age should be b/w 18 and 100");
            }
            }
    }
}
