using Assignment;
using Assignment.ExceptionHandling;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
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











