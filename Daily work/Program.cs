using Daily_work;
using Daily_work.ExceptionMessages;



public delegate void Del1(string mess);
public delegate void Del2(string mess);

class Program
{
    private static Del1 MethodA;
    public static void Main(string[] args) 
    {
        // Del1 dobj1 = DelEx.MethodA;
        Del1 dobj1 = MethodA;
        //dobj1("How r u?");

    }
}



//GenEX<int> g1 = new GenEX<int> (1, 2);
//Console.WriteLine (g1.Val1 + " " +g1.Val2);



//GenEX<string> g2 = new GenEX<string>("Adhi","amal");
//Console.WriteLine(g2.Val1 + " " + g2.Val2);



//GenEX<double> g3 = new GenEX<double>(1.2, 2.5);
//Console.WriteLine(g3.Val1 + " " + g3.Val2);


//GenEX<bool> g4 = new GenEX<bool>(true, true);
//Console.WriteLine(g4.Val1 + " " + g4.Val2);

//GenEX<int> ga = new GenEX<int>(new int[3] {1,2,3});
//ga.Display();

/*
static void Swap<T>(ref T num1, ref T num2)
{
    T temp;
    temp = num1;
    num1 = num2;
    num2 = temp;

}
int n1 = 10, n2 = 20;
char c1 = 'A', c2 = 'B';
Swap<int>(ref n1, ref n2);
Swap<char>(ref c1, ref c2);

Console.WriteLine("A = {0} B ={1}", n1, n2);
Console.WriteLine("c = {0} d ={1}", c1, c2);


*/


//FileOperations fo = new FileOperations();
//fo.CreateFile();
//fo.WriteData();
//fo.ReadData();
//fo.CopyMoveFile();
//fo.DeleteFile();
//fo.FileProperies();

