using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FamilyMember
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<FamilyMember> Children { get; set; }

        public FamilyMember(string name, int age)
        {
            Name = name;
            Age = age;
            Children = new List<FamilyMember>();
        }

        public void AddChild(FamilyMember child)
        {
            Children.Add(child);
        }
    }

    class FamilyTree
    {
        public FamilyMember Root { get; set; }

        public FamilyTree(FamilyMember root)
        {
            Root = root;
        }

        public void DisplayFamilyTree()
        {
            DisplayFamilyMemberDetails(Root, 0);
        }

        private void DisplayFamilyMemberDetails(FamilyMember member, int level)
        {
            string spaces = new string(' ', level * 4);
            Console.WriteLine($"{spaces}Name: {member.Name}, Age: {member.Age}");

            if (member.Children.Count > 0)
            {
                foreach (var child in member.Children)
                {
                    DisplayFamilyMemberDetails(child, level + 1);
                }
            }
        }
    }
}
