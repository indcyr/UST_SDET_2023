using Assignment;
using Assignment.ExceptionHandling;
using System.ComponentModel.DataAnnotations;
using System.Reflection;



//03-11-2023

//Assignment 2

FamilyMember grandparent = new FamilyMember("Grandparent", 60);
FamilyTree familyTree = new FamilyTree(grandparent);

FamilyMember parent1 = new FamilyMember("Parent 1", 65);
FamilyMember parent2 = new FamilyMember("Parent 2", 50);
FamilyMember child1 = new FamilyMember("Child 1", 28);
FamilyMember child2 = new FamilyMember("Child 2", 26);
FamilyMember grandchild1 = new FamilyMember("Grandchild 1", 11);


grandparent.AddChild(parent1);
grandparent.AddChild(parent2);
parent1.AddChild(child1);
parent1.AddChild(child2);
child1.AddChild(grandchild1);

Console.WriteLine("Family Tree:");
familyTree.DisplayFamilyTree();

//Assignment 1
//TaskItem ts = new TaskItem(1, "Birthday", false);
//TaskItem ts1 = new TaskItem(2, "Game", true);
//TaskItem ts2 = new TaskItem(3, "gym", true);
//TaskItem ts3 = new TaskItem(4, "work", false);

//TaskItem.TaskItems.Add(ts);
//TaskItem.TaskItems.Add(ts1);
//TaskItem.TaskItems.Add(ts2);
//TaskItem.TaskItems.Add(ts3);

//TaskItem.Display();
//Console.WriteLine(" Enter the id to change");
//int id = Convert.ToInt32(Console.ReadLine());
//var status = TaskItem.TaskItems.Find(x => x.TaskId == id);
//if (status != null)
//{
//    status.IsCompleted = true;
//    Console.WriteLine("Status has been changed");
//}
//else
//    Console.WriteLine("id not found");
//Console.WriteLine("Enter the id to remove Task");
//int remove = Convert.ToInt32(Console.ReadLine());
//TaskItem.TaskItems.RemoveAll(x => x.TaskId == remove);
//Console.WriteLine("Task removed succeessfully");

//Console.WriteLine("Total Tasks Are");
//TaskItem.FilteringTask();


//02-11-2023
//Assignment 2
//TourPackage package = new TourPackage(1, "AA", "02-01-2024", 1000);
//TourPackage package1 = new TourPackage(2, "BB", "12-12-2024", 2000);
//TourPackage package2 = new TourPackage(3, "CC", "12-09-2024", 3000);

//TourPackage.tourPackages.Add(package1);
//TourPackage.tourPackages.Add(package2);
//TourPackage.tourPackages.Add(package);


//Thread thread = new Thread(TourPackage.HotelReservation);

//Thread thread1 = new Thread(TourPackage.HotelReservation);

//thread.Start();
//thread.Join();
//thread1.Start();

//Assignment1

//Hotel hotel1 = new Hotel("AA", "India", 3, 5, "XX");
//Hotel hotel2 = new Hotel("BB", "Dubai", 2 ,10, "YY");


//Console.WriteLine("Available rooms at Hotel{0} is {1}", hotel1.Hotelname, hotel1.AvailableRooms);
//Console.WriteLine("Available rooms at Hotel{0} is {1}", hotel2.Hotelname, hotel2.AvailableRooms);
//await HotelBooking(hotel1, 3);
//await HotelBooking(hotel2, 4);


//Console.WriteLine("Available rooms at Hotel{0} is {1}", hotel1.Hotelname, hotel1.AvailableRooms);
//Console.WriteLine("Available rooms at Hotel{0} is {1}", hotel2.Hotelname, hotel2.AvailableRooms);


//static async Task HotelBooking(Hotel hotel, int reqrooms)
//{
//    await hotel.HotelBooK(reqrooms);
//}



//TourismDestination.DestinationDetails();

//TouristDestination.DestinationDetails();

/*
class Program
{

    public delegate void EventNotification(HotelEvent eve);
    static int capacity = 1997;
    public static void Main(string[] args)
    {
        while (true)
        {
            HotelEvent eve = new HotelEvent();
            Console.WriteLine("Enter the event name");
            string? eventName = Console.ReadLine();
            Console.WriteLine("Enter the event date");
            string? eventDate = Console.ReadLine();
            Console.WriteLine("Enter the Location");
            string? eventLocation = Console.ReadLine();
            eve.EventName = eventName;
            eve.EventDate = eventDate;
            eve.Location = eventLocation;
            eve.Capacity = capacity;
            if (capacity < 2000)
            {
                EventNotification notification = HotelEvent.EventNotification;
                notification(eve);
            }
            else
            {

                EventNotification notify = HotelEvent.EventCapacity;
                notify(eve);
                Environment.Exit(0);

            }
            Console.WriteLine("Do you want to continue\n1.yes\n2.no");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                continue;
            }
            else if (option == 2)
            {
                Environment.Exit(0);


            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        }
    }

}
*/

/*
var typ1 = "MI";
var typ2 = 1010;
var typ3 = "OnePlus";
Product<string>.AddProduct(1, ref typ1, 100, 2);
Product<int>.AddProduct(2, ref typ2, 50, 3);
Product<string>.UpdateProduct(1, typ3);
Product<string>.DeleteProduct(2);
Product<string>.SearchProduct(1);
*/

/*var typ1 = "single";
var typ2 = 2;
RoomReservation<string>.BookRoom(123, ref typ1);
RoomReservation<int>.BookRoom(101, ref typ2);
RoomReservation<string>.CancelRoom(101);
*/

/*
 while (true)
{
    Console.WriteLine("Choose your option\n 1.Add MedicalRecord\n 2.View MedicalRecord");
    int option = Convert.ToInt32(Console.ReadLine());
    FileStream fileStream = new FileStream("C:\\Users\\Administrator\\Desktop\\File\\MedicalRecord.txt",
        FileMode.Append, FileAccess.Write);
    StreamWriter writer = new StreamWriter(fileStream);


    switch (option)
    {
        case 1:
            Console.WriteLine("Enter the Record Id");
            int recordId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the patient Id");
            int patientId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Description");
            string? description = Console.ReadLine();
            Console.WriteLine("Enter the date");
            string? date = Console.ReadLine();


            MedicalHistory medicalHistory = new MedicalHistory();
            medicalHistory.RecordId = recordId;
            medicalHistory.PatientId = patientId;
            medicalHistory.Description = description;
            medicalHistory.Date = date;


            try
            {
                medicalHistory.MedRecordInfo(medicalHistory);
            }
            catch (ArgumentException ex) { Console.WriteLine(ex.Message); }

            writer.WriteLine("Record id:{0}\t patient Id:{1}\t Description is:{2}\t Date:{3}",
                recordId, patientId, description, date);
            break;


        case 2:

            writer.Close();
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\File\\MedicalRecord.txt",
                FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();


            }

            sr.Close();
            fs.Close();
            break;

    }
    writer.Close();
    Console.WriteLine("Do you want to continue\n1.yes \n2.no");
    int opp = Convert.ToInt32(Console.ReadLine());
    if (opp == 1)
    {
        continue;

    }
    else if (opp == 2)
    {
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("invalid input");
    }
}



/*
 * Assignment 2
while (true)
{
    Console.WriteLine("Choose your option\n 1.Add Patient\n 2.View patient");
    int option = Convert.ToInt32(Console.ReadLine());

    FileStream fileStream = new FileStream("C:\\Users\\Administrator\\Desktop\\File\\Patient.txt",
            FileMode.Append, FileAccess.Write);
    StreamWriter writer = new StreamWriter(fileStream);

    switch (option)
    {
        case 1:
            
            Console.WriteLine("Enter the patientid");
            int patientId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the patient name");
            string? patientName = Console.ReadLine();
            Console.WriteLine("enter the age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the diagnosis");
            string? diagnosis = Console.ReadLine();

            Patient patient = new Patient();
            patient.Name = patientName;
            patient.PatientId = patientId;
            patient.Age = age;
            patient.Diagnosis = diagnosis;

            try
            {
                patient.AddPatient(patient);
            }
            catch (ArgumentException ex) { Console.WriteLine(ex.Message); }

            writer.WriteLine("patient id:{0}\t patient name:{1}\t age is:{2}\t Diagnosis:{3}",
                patientId, patientName, age, diagnosis);
            break;


        case 2:

            writer.Close();
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\File\\Patient.txt",
                FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();


            }

            sr.Close();
            fs.Close();
            break;

    }
        
    writer.Close();
    Console.WriteLine("Do you want to continue\n1.yes \n2.no");
    int opp = Convert.ToInt32(Console.ReadLine());
    if (opp == 1)
    {
        continue;

    }
    else if (opp == 2)
    {
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("invalid input");
    }
}

*/

/*
Assignment 1 

MedicalRecord medicalrecord = new(123,2345, 333, " ", 36, "fever");

try
{
    medicalrecord.AddMedicalReport(medicalrecord);
}
catch(InvalidPatientDataException pd)
{
    Console.WriteLine(pd.Message);
}
catch (InvalidMedicalRecordException md)
{
    Console.WriteLine(md.Message);
    
}

*/

//Patient pat = new(1, "", 33, "fever");

//try
//{
//    pat.AddPatient(pat);
//}
//catch(ArgumentException ex)
//{
//    Console.WriteLine(ex.Message);
//}


/*
CallRecord cr1 = new CallRecord(123,9098909899,350);
CallRecord cr2 = new CallRecord(124,98098909899, 700);
CallRecord cr3 = new CallRecord(125, 7098909899, 1200);


CallRecord.calRec.Add(1, cr1);
CallRecord.calRec.Add(2, cr2);
CallRecord.calRec.Add(3, cr3);

CallRecord.SearchRec(98098909899);
CallRecord.TotalCalls();
*/

/*
Customer cust1 = new Customer(111, "AA", "9098909888", 10000);
Customer cust2 = new Customer(112, "BB", "8098909888", 20000);
Customer cust3 = new Customer(113, "CC", "7098909888", 15080);

Dictionary<int, Customer> customer = new Dictionary<int, Customer>();

customer.Add(1, cust1);
customer.Add(2, cust2);
customer.Add(3, cust3);

FindCustomer("6789054567");
DisplayCustomerDetails();

void FindCustomer(string phnNo)
{
    foreach (var i in customer.Values)
    {
        if(phnNo==i.PhoneNo)
        {
            Console.WriteLine("Name :" + i.Name);
            Console.WriteLine("Balance :" + i.Balance);
            break;
        }

        
    }
    

}
void DisplayCustomerDetails()
{
    foreach (var i in customer.Values)
    {
        Console.WriteLine("Cust Id : {0} \n Name: {1} \n Phone No: {2} \n Balance: {3}", i.CustId, i.Name, i.PhoneNo, i.Balance);
    }
}
*/











