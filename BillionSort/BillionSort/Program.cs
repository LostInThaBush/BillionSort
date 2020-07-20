using BillionSort.Models;
using System;

namespace BillionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            DbMethods dbMethods = new DbMethods("Accounts");
            dbMethods.AddAccount("AE@isFake.com", "AlsoItsPassword");
        }
    }
}
