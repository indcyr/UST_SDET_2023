using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Hotel : TourismDestination
    {
        public Hotel(string? name, string? country, int rating,
            int availableRooms, string? hotelname) : base(name, country, rating)
        {

            AvailableRooms = availableRooms;
            Hotelname = hotelname;
        }

        public int AvailableRooms { get; set; }
        public String? Hotelname { get; set; }


        public async Task HotelBooK(int reqRooms)
        {
            if (reqRooms <= AvailableRooms)
            {

                await Task.Delay(1000);

                AvailableRooms -= reqRooms;


                Console.WriteLine($"{reqRooms} are booked. Available rooms are :{AvailableRooms}");


            }
            else
            {
                Console.WriteLine("Sorry rooms are not available");

            }

        }
    }
}
