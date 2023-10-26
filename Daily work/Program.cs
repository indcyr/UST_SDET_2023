using Daily_work;
using Daily_work.ExceptionMessages;

ExceptionHandling excep = new ExceptionHandling(10, 20);

//excep.Divide();
try
{
    excep.Divide();
}
catch (ArithmeticException ex)
{
    Console.WriteLine(MyExceptions.exmesslist["Div"]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(MyExceptions.exmesslist["I"]);
}
catch (Exception ex)
{
    Console.WriteLine(MyExceptions.exmesslist["U"]);
}
finally
{
    Console.WriteLine("Done");
}