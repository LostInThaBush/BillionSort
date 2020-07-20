using BillionSort.Models;
using System;

namespace BillionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            DbMethods dbMethods = new DbMethods("Accounts");

            dbMethods.AddAccount("RARA.Hacha@gmail.com", "Booze");
            for (int i =0; i<2; i++)
            {
                Console.WriteLine("Enter SQL Command: ");
                var command = Console.ReadLine();
                dbMethods.CustomSQLCommand(command);
            }
            Console.ReadLine();
        }
    }
}
