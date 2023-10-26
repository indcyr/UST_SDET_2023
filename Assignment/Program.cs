using Assignment;
using System.ComponentModel.DataAnnotations;

Patient pat = new(1, "", 33, "fever");

try
{
    pat.AddPatient(pat);
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}


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









