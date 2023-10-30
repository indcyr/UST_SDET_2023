using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class RoomReservation<T>
    {
        public static List<HotelRoom<T>> hotelRoom = new();
        public static void BookRoom(int roomno, ref T roomtype)
        {
            HotelRoom<T> hotel = new(roomno, roomtype, true);
            hotelRoom.Add(hotel);
            Console.WriteLine("Room Number: {0} Room Type: {1}", hotel.RoomNumber, hotel.RoomType);
        }
        public static void CancelRoom(int roomno)
        {


            foreach (var item in hotelRoom)
            {
                if (item.RoomNumber == roomno)
                {
                    item.IsBooked = false;
                    Console.WriteLine("Booking is cancelled");
                    break;
                }
            }

        }
    }
}
