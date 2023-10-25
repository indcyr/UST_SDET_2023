using Assignment;

/*InsurancePolicy ip = new("Policy1", 123, 8999);
ip.RenewPolicy(10999);
InsurancePolicy ip2 = new("Policy2", 133, 10000);
ip2.RenewPolicy();
*/

LifeInsurance l1 = new("Policy1", 123, 8999,60);
Console.WriteLine("Policy Name : {0} \t Policy Id : {1} \t Age : {2} \n",l1.PolicyName,l1.PolicyId,l1.Age);
Console.WriteLine("Updated Premium" + l1.CalculatePremium());

CarInsurance car1 = new CarInsurance("Policy 2",133,10000,"Petrol");
Console.WriteLine("Policy Name : {0} \t Policy Id : {1} \t Fuel Type : {2} \n", car1.PolicyName, car1.PolicyId, car1.FuelType);
Console.WriteLine("Updated Premium" + car1.CalculatePremium());








