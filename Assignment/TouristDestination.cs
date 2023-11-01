using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class TouristDestination
    {
        public TouristDestination(string? name, string? country, int rating, double pricePerNight)
        {
            Name = name;
            Country = country;
            Rating = rating;
            PricePerNight = pricePerNight;
        }

        public string? Name { get; set; }
        public string? Country { get; set; }
        public int Rating { get; set; }
        public double PricePerNight { get; set; }

        public static void DestinationDetails()
        {
            List<TouristDestination> destinations = new List<TouristDestination>();
            destinations.Add(new TouristDestination("Bali", "Indonesia", 5,20000));
            destinations.Add(new TouristDestination("TVM", "India", 1,1000));
            destinations.Add(new TouristDestination("Scotland", "UK", 4,40000));
            destinations.Add(new TouristDestination("Florida", "USA", 3,30000));
            destinations.Add(new TouristDestination("Tokyo", "Japan", 2, 100000));

            Console.WriteLine("Destinations having rating greater than 3");
            var result = destinations.FindAll(t => t.Rating>3);
            foreach (var item in result)
            {
                Console.WriteLine(item.Name + " " + item.Country + " " + item.Rating);
            }
            Console.WriteLine(" ");

            Console.WriteLine("Order by Price per Night");


            var res = destinations.OrderBy(t => t.PricePerNight );
            foreach (var item in res)
            {
                Console.WriteLine(item.Name + " " + item.Country + " " + item.Rating);
            }
            Console.WriteLine(" ");

            Console.WriteLine("Based On Tourist locations in Japan");
            var loc = destinations.Where(t => t.Country.Equals("Japan"));
            foreach (var item in loc)
            {
                Console.WriteLine(item.Name + " " + item.Country + " " + item.Rating);
            }


        }
    }
}
