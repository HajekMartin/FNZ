using FNZ.Models;

Console.WriteLine("Start ...");

Customers customers = new Customers();

customers.AddCustomer(new Customer("Martin",new DateTime(2000, 10, 21), Gender.Male));
customers.AddCustomer(new Customer("Julia", new DateTime(2000, 10, 22), Gender.Female));

DateTime actualTime = DateTime.Now;

double avgMale = customers.AverageAge(Gender.Male);
Console.WriteLine($"Average for males : {avgMale}");

double avgFemale = customers.AverageAge(Gender.Female);
Console.WriteLine($"Average for males : {avgFemale}");

double totalAvg = customers.AverageAge(null);
Console.WriteLine($"Total average : {totalAvg}");