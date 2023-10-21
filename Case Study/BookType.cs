using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class BookType : Book
    {
        public BookType(string? genre, string? title, string? authors, int iSBN, double price, string availability):base(title,authors, iSBN, price,availability)
        {
            Genre = genre;
        }
        public string? Genre { get; set; }

        public void DisplayBookDetails()
        {
            Console.WriteLine("Title : {0} \n Authors : {1} \n ISBN : {2} \n price : {3}\n Availability : {4} \n Genre : {5}", title, authors, ISBN, price, Availability,Genre);
        }
    }
}
