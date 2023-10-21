using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Order
    {
        public string? Books { get; set; }

        public string? OrderDate { get; set; }

        public double cost { get; set; }
        public void DisplayOrderDetails()
        {
            Console.WriteLine("Books : {0} \n Order Date : {1} \n Cost : {2}",Books,OrderDate,cost);
        }
    }
}
