using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Customer
    {
        public Customer(int custId, string? name, string? phoneNo, double balance)
        {
            CustId = custId;
            Name = name;
            PhoneNo = phoneNo;
            Balance = balance;
        }

        public int CustId { get; set; }
        public string? Name { get; set; }
        public string? PhoneNo { get; set; }
        public double Balance { get; set; }

        
    }
}
