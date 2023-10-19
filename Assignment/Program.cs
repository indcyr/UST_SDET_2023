using Assignment;

/*Product product1 = new Product("abc",20,18);
Product product2 = new Product("xyz", 10, 10);
Product product3 = new Product("def", 15, 20);

Product[] products = {product1, product2, product3};

for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine("Product Name : " + products[i].ProductName);
    Console.WriteLine("Price : " + products[i].Price);
    Console.WriteLine("Quantity : " + products[i].Quantity);
    Console.WriteLine("Total value : " + products[i].ProductValue());
}
*/

Student[] student = new Student[3];
student[0] = new Student("XYZ",new int[] {10,20,30},"A");
student[1] = new Student("ABC", new int[] { 12, 22, 32 }, "B");
student[2] = new Student("DEF", new int[] { 9, 18, 11 }, "C");

foreach (Student s in student)
{
    s.DisplayStudentInfo();
    s.GetMarksSummary();
}
