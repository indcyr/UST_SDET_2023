using Case_Study;

Console.WriteLine("1. Add Book \n 2. Add Customer \n 3. Place Order \n 4.Exit Order");

Order order = new Order();
int option = Convert.ToInt32(Console.ReadLine());
BookType[] bookType = new BookType[]
{
    new("Fiction","The Secret","ABC",123,500,"Y"),
    new("Fiction","Title2","XYZ",234,400,"Y")
};

switch(option)
{
    case 1:
        Console.WriteLine("Books added");
        foreach (BookType item in bookType)
        {
            item.DisplayBookDetails();
        }
        break;

    case 2:
        Console.WriteLine("Enter Customer Id");
        int CID = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter customer name:");
        string? cname= Console.ReadLine();
        Console.WriteLine("Enter contactnumber:");
        string? contact = Console.ReadLine();
        Customer customer = new Customer(cname,contact,CID);
        customer.DisplayCustomerDetails();
        break;
    
    case 3:
        Console.WriteLine("Enter the title of the book");
        string? Title = Console.ReadLine();
        foreach (var item in bookType)
        {
            if(item.title.Equals(Title))
            {
                Console.WriteLine("Enter order date:");
                order.OrderDate = Console.ReadLine();
                Console.WriteLine("Order Placed");
                Console.WriteLine("Book Title : {0} \n Book Price: {1} Book Availability: {2}", item.title, item.price, item.Availability);
                order.cost = item.price;
                Console.WriteLine("Total cost is:{0}", order.cost);
                
            }
            else
            { 
                Console.WriteLine("Book is not available");
            }
        }
        break;
    case 4:
        Environment.Exit(0);
        break;

}