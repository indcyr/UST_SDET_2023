
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Product
    {
        private string productName;
        private double price, quantity;

        public string ProductName { get => productName; set => productName = value; }
        public double Price { get => price; set => price = value; }
        public double Quantity { get => quantity; set => quantity = value; }

        public Product(string productName, double price, double quantity)
        {
            this.ProductName = productName;
            this.Price = price;
            this.Quantity = quantity;
        }
        public void SetPrice(double newPrice)
        {
            Price = newPrice;
        }
        public double ProductValue() 
        {
         return Price * Quantity;
        }
        public void DisplayProduct()
        {
            Console.WriteLine("Product Name: " + productName);
            Console.WriteLine("Price :" + price);
            Console.WriteLine("Quantity: " + quantity);
        }
    }
}
