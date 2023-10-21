using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Customer
    {
        public Customer(string? cname, string? contact, int cID)
        {
            this.cname = cname;
            this.contact = contact;
            CID = cID;
        }

        public string? cname { get; set; }

        public string? contact { get; set; }

        public int CID { get; set; }

        public void DisplayCustomerDetails()
        {
            Console.WriteLine("Customer Name : {0} \n Contact: {1} \n CID : {2}",cname,contact,CID);
        }
    }
}
