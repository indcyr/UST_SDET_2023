using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class PhysicalProduct : Product
    {
        public double Weight { get; set; }
        public string? Dimensions { get; set; }

        public static List<PhysicalProduct> Products = new List<PhysicalProduct>();

        public void DeliveringProduct()
        {
            Console.WriteLine("product is shipped and shipping cost is {0}", Weight * 10);
        }

        public void PlacingOrder()
        {
            Console.WriteLine("Do you want to continue the order\n1.yes\n2.no");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                if (StockQuantity > 0)
                    Console.WriteLine("Continue to payment");
                else
                    Console.WriteLine("product not available");
            }
            else
            {
                Console.WriteLine("reverting");
            }

        }

        public void ProcessingPayment()
        {
            Console.WriteLine("Enter the card details for product {0}", Name);
            string? crednum = Console.ReadLine();
            if (crednum == null)
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                Console.WriteLine("payment successful");
            }
        }
    }
}
