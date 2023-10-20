using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class DigitalProduct : ElectronicProduct
    {
        public DigitalProduct(string? fileFormat,int warrantyPeriod, string? productName, double price,int quantity):base(warrantyPeriod,productName,price,quantity)
        {
            FileFormat = fileFormat;
        }

        public string? FileFormat { get; set; }

        public void DisplayDigitalProduct()
        {
            Console.WriteLine("File Format: {0}", FileFormat);
        }
    }
}
