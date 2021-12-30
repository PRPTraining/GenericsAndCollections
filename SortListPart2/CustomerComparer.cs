using System;
using SortListLibrary;
namespace SortListPart2
{
    //Sorting Customer based on name.
    public class CustomerComparer : IComparer<Customer>
    {
        public int Compare(Customer? x, Customer? y)
        {
            if (x?.Salary > y?.Salary)
                return -1;
            else if (x?.Salary < y?.Salary)
                return 1;
            else
                return 0;
        }
    }
}

