namespace Assignment
{
    internal class TourismDestination
    {
        public TourismDestination(string? name, string? country, int rating)
        {
            Name = name;
            Country = country;
            Rating = rating;
        }

        public string? Name { get; set; }
        public string? Country { get; set; }
        public int Rating { get; set; }

        public static void DestinationDetails()
        {
            List<TourismDestination> destinations = new List<TourismDestination>();
            destinations.Add(new TourismDestination("Bali","Indonesia",5));
            destinations.Add(new TourismDestination("TVM", "India", 1));
            destinations.Add(new TourismDestination("Scotland", "UK", 4));
            destinations.Add(new TourismDestination("Florida", "USA", 3));
            destinations.Add(new TourismDestination("Tokyo", "Indonesia", 5));

            var result = destinations.OrderByDescending(t => t.Rating);
            foreach (var item in result)
            {
                Console.WriteLine(item.Name + " " + item.Country + " " + item.Rating);
            }


        }
    }
}
