using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class College
    {
        public string? CName{ get; set; }

        public string? CType { get; set; }

        public int CID { get; set; }
        public void DisplayCollegeDetails()
        {
            Console.WriteLine("College Name : {0} \n College Type: {1} \n College ID : {2}", CName, CType, CID);
        }
    }
}
