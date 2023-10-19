using Assignment;

Product product1 = new Product("abc",20,18);
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