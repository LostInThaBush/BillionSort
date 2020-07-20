using BillionSort.Accounts;
using System;
using BillionSort.Logs;
namespace BillionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            DbMethods dbMethods = new DbMethods("Accounts");
            Log log = new Log();
            log.CheckLog();
            Console.ReadLine();
        }
    }
}
