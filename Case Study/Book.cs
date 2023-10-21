using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Book
    {
        public Book(string? title, string? authors, int iSBN, double price, string? availability)
        {
            this.title = title;
            this.authors = authors;
            ISBN = iSBN;
            this.price = price;
            Availability = availability;
        }

        public string? title { get; set; }
        public string? authors { get; set; }
        public int ISBN { get; set; }
        public double price { get; set; }
        public string? Availability { get; set; }

        
    }
}
