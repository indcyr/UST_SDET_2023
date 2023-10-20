using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class ClothingProduct : Product
    {
        public ClothingProduct(string? size, string? productName, double price, int quantity):base(productName,price,quantity) 
        {
            Size = size;
        }

        public string? Size { get; set; }

        public void DisplayClothingProduct()
        {
            Console.WriteLine("Size : {0},", Size);
        }
    }
}
