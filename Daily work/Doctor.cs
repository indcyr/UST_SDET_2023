using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_work
{
    internal class Doctor : iDoctor
    {
        public int Did { get; set; }
        public string? DName { get; set; }

        public void AddNewDoctor(int did,string? dName)
        {
            Did = did;
            DName = dName;
        }

        public void ModifyNewDoctor(int did, string? dName)
        {
            Did = did;
            DName = dName;
        }
        public void DisplayDoctorDetails() 
        {
            Console.WriteLine("Did : {0} \t Name : {1} ", Did, DName);
        }
    }
}
