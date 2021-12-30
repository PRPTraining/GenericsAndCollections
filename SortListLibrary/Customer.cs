using System;
namespace SortListLibrary
{
    public class Customer : IComparable<Customer>
    {

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int Salary { get; set; }
      

        public int CompareTo(Customer? other)
        {
            if (this.CustomerId > other.CustomerId)
                return 1;
            else if (this.CustomerId < other.CustomerId)
                return -1;
            else
                return 0;
        }
    }
}

