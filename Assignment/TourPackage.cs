using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class TourPackage
    {
        public TourPackage(int packageId, string? destination, string? startDate, int price)
        {
            PackageId = packageId;
            Destination = destination;
            StartDate = startDate;
            Price = price;
        }

        public int PackageId { get; set; }
        public string? Destination { get; set; }
        public string? StartDate { get; set; }
        public int Price { get; set; }

        public static List<TourPackage> tourPackages = new List<TourPackage>();
        public static void HotelReservation()
        {

            Console.WriteLine("Enter the id to book");
            int num = Convert.ToInt32(Console.ReadLine());
            lock (tourPackages)
            {
                var b = tourPackages.Find(x => x.PackageId == num);
                Console.WriteLine("package booked Destination:{0}\tStartSate:{1}\tPrice:{2}", b.Destination, b.StartDate, b.Price);
            }
        }

    }
}
