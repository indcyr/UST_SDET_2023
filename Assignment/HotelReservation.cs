using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class HotelReservation<T>
    {
        public static List<T> listOfHotelRoom = new List<T>();
        public void BookRoom(T obj)
        {
            listOfHotelRoom.Add(obj);
            Console.WriteLine("Room booked successfully");
        }
        public void CancelRoom(T obj)
        {
            listOfHotelRoom.Remove(obj);
            Console.WriteLine("Room canceled");
        }
    }
}
