// See https://aka.ms/new-console-template for more information

//How to add custom sort logic while consuming a dll.
using SortListLibrary;
using SortListPart2;

Console.WriteLine("Customer class library Sorting based on Salary descending");

List<Customer> customers = new()
{
    new Customer { CustomerId = 150, CustomerName = "Tony",Salary=5000 },
    new Customer { CustomerId = 100, CustomerName = "Rina",Salary=10000 },
    new Customer { CustomerId = 50, CustomerName = "Angel" ,Salary=6000}
};

customers.Sort(new CustomerComparer());

foreach(var customer in customers)
    Console.WriteLine($"{customer.CustomerId}-{customer.CustomerName}-{customer.Salary}");

