using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class HotelEvent
    {
        public string? EventName { get; set; }
        public string? EventDate { get; set; }

        public string? Location { get; set; }

        public int Capacity { get; set; }

        public static void EventNotification(HotelEvent eve)
        {
            Console.WriteLine("Successfully registered for the event {0} on {1} at {2}", eve.EventName, eve.EventDate, eve.Location);
        }
        public static void EventCapacity(HotelEvent eve)
        {
            Console.WriteLine("Capacity is full so registration closed");

        }
    }
}
