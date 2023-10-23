using Daily_work;

//BankDetails bank = new BankDetails(1234, 1234567890L, "AA", "Inactive");
//BankDetails bank1 = new();
BankDetailsNew bank2= new(999, 1234512345L, "XX","Inactive");

bank2.WelcomeMessage();
bank2.WelcomeMessage();
bank2.ExitMess();
Console.WriteLine("1.Custid 2.Accno 3.Name");
int ch = Convert.ToInt32(Console.ReadLine());


switch(ch)
{
    case 1:
        Console.WriteLine("Custid : ");
        bank2.GetAccDetails(Convert.ToInt32(Console.ReadLine()));
        break;
    case 2:
        Console.WriteLine("Acc No:");
        bank2.GetAccDetails(Convert.ToInt64(Console.ReadLine()));
        break;
    case 3:
        Console.WriteLine("Name :");
        bank2.GetAccDetails(Console.ReadLine());
        break;
    default:
        Console.WriteLine("Enter b/w 1-3");
        break;
}