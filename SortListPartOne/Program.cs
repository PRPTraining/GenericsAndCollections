// See https://aka.ms/new-console-template for more information
using SortListLibrary;


Console.WriteLine("Demo - Sorting a List with integer type");
List<int> numbers = new List<int> { 3, 2, 5, 1 };
numbers.Sort();
Console.WriteLine("Sorted numbers");
foreach(int number in numbers)
{
    Console.WriteLine(number);
}
Console.WriteLine("**********************************");
Console.WriteLine("Demo- Sorting List<Customer>");

List<Customer> customers = new()
{
    new Customer { CustomerId = 150, CustomerName = "Tony" },
    new Customer { CustomerId = 100, CustomerName = "Rina" },
    new Customer { CustomerId = 50, CustomerName = "Angel" }
};

//customers.Sort();
// Here sort will not work because the compiler doesn't know which fields to comapre.
//In such cases we need to define our logic in the Customer class by implementing the IComparable<T> interface.

customers.Sort();
Console.WriteLine("After implementing the IComparable<T> interface in Customer class...");
foreach(var customer in customers)
    Console.WriteLine($"{customer.CustomerId} - {customer.CustomerName}");
