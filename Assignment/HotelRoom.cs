using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class HotelRoom<T>
    {
        private int roomNumber;
        private T roomType;
        private bool isBooked;

        public HotelRoom(int roomNumber, T roomType, bool isBooked)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            IsBooked = isBooked;
        }

        public int RoomNumber { get => roomNumber; set => roomNumber = value; }
        public T RoomType { get => roomType; set => roomType = value; }
        public bool IsBooked { get => isBooked; set => isBooked = value; }
    }
}