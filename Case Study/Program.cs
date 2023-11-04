using Case_Study;
using Case_Study.ExceptionFolder;


//CaseStudy 4/11/23
public delegate void EnrollementHandler(Student student, Course course);
public delegate void EnrollmentHandler(EnrollementRecord enrollrec);

class Program
{
    public static void Main(string[] args)
    {
        Student studentrecord = new();
        Course courserecord1 = new Course()
        {
            CourseCode = 001,
            Title = "AAA",
            Instructor = "INST1"
        };
        Course courserecord2 = new Course()
        {
            CourseCode = 002,
            Title = "BBB",
            Instructor = "INST2"
        };
        Course courserecord3 = new Course()
        {
            CourseCode = 003,
            Title = "CCC",
            Instructor = "INST3"
        };
        Course courserecord4 = new Course()
        {
            CourseCode = 004,
            Title = "DDD",
            Instructor = "INST4"
        };
        EnrollementRecord.courses.Add(courserecord1);
        EnrollementRecord.courses.Add(courserecord2);
        EnrollementRecord.courses.Add(courserecord3);
        EnrollementRecord.courses.Add(courserecord4);
    repeat1:
    repeat2:
        Console.WriteLine("1.Admin 2.student");
        string? choose = Console.ReadLine();
        if (choose == "1")
        {
        repeat:
            Console.WriteLine("1.Add Course 2.View Course 3.Remove Course 4.Students List 5.Go Back");
            string? choose1 = Console.ReadLine();
            if (choose1 == "1")
            {
                Course courserecord5 = new Course()
                {
                    CourseCode = 127,
                    Title = "BTech",
                    Instructor = "Rolex"
                };
                EnrollementRecord.courses.Add(courserecord5);
                Console.WriteLine("Courses Added Successfully");
            }
            else if (choose1 == "2")
            {
                Console.WriteLine("Courses:");
                foreach (var crse in EnrollementRecord.courses)
                {
                    Console.WriteLine("Course Code: {0}, Course Name: {1}, Instructor: {2}", crse.CourseCode, crse.Title, crse.Instructor);
                }
            }
            else if (choose1 == "3")
            {
                EnrollementRecord.courses.Remove(courserecord4);
                Console.WriteLine("Courses Removed Successfully");
            }
            else if (choose1 == "4")
            {
                Console.WriteLine("Courses");
                foreach (var crse in EnrollementRecord.enrollementRecords)
                {
                    Console.WriteLine("Course Code: {0}, Course Name: {1}, Instructor: {2}, StudentID:{3}, Student Name: {4}, Email: {5}", crse.Course.CourseCode, crse.Course.Title, crse.Course.Instructor, crse.Student.StudentID, crse.Student.Name, crse.Student.Email);
                }
            }
            else if (choose1 == "5") { goto repeat1; }
            goto repeat;
        }
        else if (choose == "2")
        {
        repeat3:
            Console.WriteLine("1. Register student 2. Course Registration 3. Course Withdrawal");
            string? choose2 = Console.ReadLine();
            if (choose2 == "1")
            {
                Console.WriteLine("Enter student ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter student Name:");
                string? name = Console.ReadLine();
                Console.WriteLine("Enter Email:");
                string? email = Console.ReadLine();
                studentrecord = new()
                {
                    StudentID = id,
                    Name = name,
                    Email = email
                };
                EnrollementRecord.students.Add(studentrecord);
                goto repeat3;
            }
            else if (choose2 == "2")
            {
                Console.WriteLine("Courses:");
                foreach (var crse in EnrollementRecord.courses)
                {
                    Console.WriteLine("Course Code: {0}, Course Name: {1}, Instructor: {2}", crse.CourseCode, crse.Title, crse.Instructor);
                }
                try
                {
                    Console.WriteLine("Course for Registration:");
                    int regcourse = Convert.ToInt32(Console.ReadLine());
                    Course regstrcourse = EnrollementRecord.courses.FirstOrDefault(c => c.CourseCode == regcourse);
                    EnrollAsync(studentrecord, regstrcourse);
                    Console.WriteLine("Enrolled in course");
                    Console.WriteLine("Course Details:");
                }
                catch (EnrollementException ex) { Console.WriteLine(ex.Message); }

            }
            else if (choose2 == "3")
            {
                Console.WriteLine("Courses:");
                foreach (var crse in EnrollementRecord.courses)
                {
                    Console.WriteLine("Course Code: {0}, Course Name: {1}, Instructor: {2}", crse.CourseCode, crse.Title, crse.Instructor);
                }
                try
                {
                    Console.WriteLine("Course for deletion");
                    int regcourse = Convert.ToInt32(Console.ReadLine());
                    EnrollementRecord record = EnrollementRecord.enrollementRecords.FirstOrDefault(c => c.Course.CourseCode == regcourse);
                    WihtdrawAsync(record);
                    Console.WriteLine("Removed from course");
                }
                catch (EnrollementException ex) { Console.WriteLine(ex.Message); }
            }
        }
        Console.WriteLine("Do you want to continue? (Y/N)");
        string? titleread = Console.ReadLine();
        if (titleread == "y")
        {
            goto repeat2;
        }
    }
    public static async Task EnrollAsync(Student student, Course course)
    {
        await Task.Delay(100);
        EnrollementHandler enrolhand = course.CourseRegistration;
        enrolhand.Invoke(student, course);
    }
    public static async Task WihtdrawAsync(EnrollementRecord enrollrec)
    {
        await Task.Delay(100);
        Course coure = new();
        EnrollmentHandler enrolhand1 = coure.CourseWithdrawal;
        enrolhand1.Invoke(enrollrec);
    }
}
//Customers cust1 = new Customers();
//cust1.CustomerID = 001;
//cust1.CustomerName = "XX";
//cust1.CustomerEmail = "XX@gmail.com";
//Customers.customers.Add(cust1);
//Customers cust2 = new Customers();
//cust2.CustomerID = 002;
//cust2.CustomerName = "AA";
//cust2.CustomerEmail = "AA@gmail.com";
//Customers.customers.Add(cust2);
//Customers cust3 = new Customers();
//cust3.CustomerID = 003;
//cust3.CustomerName = "BB";
//cust3.CustomerEmail = "BB@gmail.com";
//Customers.customers.Add(cust3);

//while (true)
//{
//    Console.WriteLine("choose your option\n1.User\n2.Admin");
//    int option = Convert.ToInt32(Console.ReadLine());

//    if (option == 1)

//    {
//        Console.WriteLine("Enter the customer id");
//        int cusId = Convert.ToInt32(Console.ReadLine());
//        if (Customers.customers.Find(x => x.CustomerID == cusId) == null)
//        {
//            Console.WriteLine("Customer not found");
//            break;
//        }
//        while (true)
//        {
//            Console.WriteLine("choose your option\n1.Add product to cart\n2.view Cart\n3.place order\n4.Support\n5.view orders");
//            int optionuser = Convert.ToInt32(Console.ReadLine());

//            switch (optionuser)
//            {

//                case 1:

//                    Console.WriteLine("Enter Product id for add to cart");
//                    int productId = Convert.ToInt32(Console.ReadLine());
//                    Customers customer1 = Customers.customers.Find(x => x.CustomerID == cusId);
//                    if (DigitalProduct.Products.Find(x => x.ProductId == productId) == null)
//                    {
//                        if (PhysicalProduct.Products.Find(x => x.ProductId == productId) == null)
//                        {
//                            Console.WriteLine("invalid product id");
//                        }
//                        else
//                        {
//                            customer1.ordersphy.Add(PhysicalProduct.Products.Find(x => x.ProductId == productId));
//                            Console.WriteLine("product added to cart");
//                        }
//                    }
//                    else
//                    {
//                        customer1.orders.Add(DigitalProduct.Products.Find(x => x.ProductId == productId));
//                        Console.WriteLine("product added to cart");
//                    }
//                    break;
//                case 2:
//                    Console.WriteLine("Products are");
//                    if (DigitalProduct.Products.Count == 0 && PhysicalProduct.Products.Count == 0)
//                    {
//                        Console.WriteLine("No Product Found found");
//                    }
//                    foreach (var item in DigitalProduct.Products)
//                    {
//                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
//                            item.Name, item.Price, item.StockQuantity, item.FileFormat, item.DownloadLink);
//                    }
//                    foreach (var item in PhysicalProduct.Products)
//                    {
//                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
//                            "\tDimension:{5}", item.ProductId,
//                            item.Name, item.Price, item.StockQuantity, item.StockQuantity, item.Dimensions);
//                    }
//                    break;
//                case 3:
//                    Customers customer = Customers.customers.Find(x => x.CustomerID == cusId);
//                    if (customer.orders.Count == 0 && customer.ordersphy.Count == 0)
//                    {
//                        Console.WriteLine("no product found in cart");
//                    }
//                    else
//                    {
//                        foreach (var item in customer.orders)
//                        {
//                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
//                             item.Name, item.Price, item.StockQuantity, item.FileFormat, item.DownloadLink);
//                            item.PlacingOrder();
//                            item.ProcessingPayment();
//                            item.DeliveringProduct();

//                        }
//                        foreach (var item in customer.ordersphy)
//                        {
//                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
//                           "\tDimension:{5}", item.ProductId,
//                           item.Name, item.Price, item.StockQuantity, item.StockQuantity, item.Dimensions);
//                            item.PlacingOrder();
//                            item.ProcessingPayment();
//                            item.DeliveringProduct();
//                        }
//                        Console.WriteLine("do you want to place all the order\n1.yes\n2.no");
//                        int confirm = Convert.ToInt32(Console.ReadLine());
//                        if (confirm == 1)
//                        {
//                            customer.confirmedorders.AddRange(customer.orders);
//                            customer.orders.Clear();
//                            customer.confirmedordersphy.AddRange(customer.ordersphy);
//                            customer.ordersphy.Clear();
//                            Console.WriteLine("order placed successfully");
//                        }
//                        else
//                        {
//                            Console.WriteLine("removing everything in cart");
//                        }


//                    }



//                    break;
//                case 4:
//                    Console.WriteLine("For support, dial 9876543210");
//                    break;
//                case 5:
//                    Customers customer2 = Customers.customers.Find(x => x.CustomerID == cusId);
//                    if (customer2.confirmedorders.Count == 0 && customer2.confirmedordersphy.Count == 0)
//                    {
//                        Console.WriteLine("no order details found");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Orders are");
//                        foreach (var item in customer2.confirmedorders)
//                        {
//                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
//                            item.Name, item.Price, item.StockQuantity, item.FileFormat, item.DownloadLink);
//                        }
//                        foreach (var item in customer2.confirmedordersphy)
//                        {
//                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
//                           "\tDimension:{5}", item.ProductId,
//                           item.Name, item.Price, item.StockQuantity, item.StockQuantity, item.Dimensions);
//                        }
//                    }
//                    break;
//                default:
//                    Console.WriteLine("invalid input");

//                    break;
//            }

//            Console.WriteLine("do you want to continue as user\n1.yes\n2.no");
//            int optuser = Convert.ToInt32(Console.ReadLine());
//            if (optuser == 1)
//            {
//                continue;
//            }
//            else if (optuser == 2)
//            {
//                break;
//            }
//            else
//            {
//                Console.WriteLine("invalid input");
//            }
//        }


//    }

//    else if (option == 2)
//    {
//        Console.WriteLine("choose option\n1.Add Product\n2.View report");
//        int optionadmin = Convert.ToInt32(Console.ReadLine());
//        if (optionadmin == 1)
//        {
//            Console.WriteLine("choose the option \n1.Digital Product\n2.Physical Product");
//            int optionProduct = Convert.ToInt32(Console.ReadLine());
//            if (optionProduct == 1)
//            {
//                Console.WriteLine("Enter Product id");
//                int productid = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Enter Product Name");
//                string? productName = Console.ReadLine();
//                Console.WriteLine("enter the price");
//                double productCost = Convert.ToDouble(Console.ReadLine());
//                Console.WriteLine("Enter the fileformat");
//                string? fileFormat = Console.ReadLine();
//                Console.WriteLine("Enter downloadLink");
//                string? downloadLink = Console.ReadLine();
//                Console.WriteLine("Enter the Quantity");
//                int quantity = Convert.ToInt32(Console.ReadLine());


//                DigitalProduct digitalProduct = new DigitalProduct();
//                digitalProduct.Name = productName;
//                digitalProduct.ProductId = productid;
//                digitalProduct.FileFormat = fileFormat;
//                digitalProduct.DownloadLink = downloadLink;
//                digitalProduct.Price = productCost;
//                digitalProduct.StockQuantity = quantity;
//                DigitalProduct.Products.Add(digitalProduct);
//            }
//            else if (optionProduct == 2)
//            {
//                Console.WriteLine("Enter Product id");
//                int productid = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Enter Product Name");
//                string? productName = Console.ReadLine();
//                Console.WriteLine("enter the price");
//                double productCost = Convert.ToDouble(Console.ReadLine());
//                Console.WriteLine("Enter the Weight");
//                int weight = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Enter dimension");
//                string? dimension = Console.ReadLine();
//                Console.WriteLine("Enter the Quantity");
//                int quantity = Convert.ToInt32(Console.ReadLine());

//                PhysicalProduct physicalProduct = new PhysicalProduct();
//                physicalProduct.Name = productName;
//                physicalProduct.ProductId = productid;
//                physicalProduct.Price = productCost;
//                physicalProduct.Dimensions = dimension;
//                physicalProduct.Weight = weight;
//                physicalProduct.StockQuantity = quantity;


//                PhysicalProduct.Products.Add(physicalProduct);
//            }
//            else
//            {
//                Console.WriteLine("Invalid");
//            }
//        }
//    }
//    else
//    {
//        Console.WriteLine("invalid option");
//    }
//    Console.WriteLine("do you want to continue\n1.yes\n2.no");
//    int opt = Convert.ToInt32(Console.ReadLine());
//    if (opt == 1)
//    {
//        continue;
//    }
//    else if (opt == 2)
//    {
//        Environment.Exit(0);
//    }
//    else
//    {
//        Console.WriteLine("invalid input");
//    }

//}



/*
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
*/