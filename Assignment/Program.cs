using Assignment;

Console.WriteLine("1.Electronic Product 2. Digital Product 3. Clothing Product");

switch(Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        ElectronicProduct ep = new(2, "Laptop", 100000, 2);
        ep.DisplayProduct();
        ep.DisplayWarrantyPeriod();
        break;

    case 2:
        DigitalProduct dp = new DigitalProduct("PDF", 2, "Pro Name", 75000, 1);
        dp.DisplayProduct();
        dp.DisplayWarrantyPeriod();
        dp.DisplayDigitalProduct();
        break;
    case 3:
        ClothingProduct cp = new("S", "Top", 799, 5);
        cp.DisplayProduct();
        cp.DisplayClothingProduct();
        break;
}