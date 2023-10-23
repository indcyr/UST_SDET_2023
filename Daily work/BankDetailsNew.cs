using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_work
{
    internal class BankDetailsNew : BankDetails
    {
        public BankDetailsNew(int custid, long accno, string? name, string? status) : base(custid, accno, name, status)
        {
        }
        public override void WelcomeMessage()
        {
            Console.WriteLine("Welcome {0} !!", Name);
        }
        public void ExitMess()
        {
            Console.WriteLine("Done");
        }
    }
}
