using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class StaffDetails
    {
        public int StaffId { get; set; }
        public string? Name { get; set; }

        public string? Dept { get; set; }

        public void DisplayStaffDetails()
        {
            Console.WriteLine("ID : {0} \n Name : {1} \n " + "DEpt : {2}", StaffId, Name, Dept);

        }

    }
}
