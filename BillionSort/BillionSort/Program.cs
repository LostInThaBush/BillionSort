using BillionSort.Accounts;
using System;
using BillionSort.Logs;
using BillionSort.Accounts.Import;

namespace BillionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            DbMethods dbMethods = new DbMethods("Accounts");
            Log log = new Log();
            log.CheckLog();
            for (int i = 0; i<20; i++)
            {
                string actualLine = "Line"+i;
                log.WriteLine(actualLine);
            }
            ImportTXT importTXT = new ImportTXT(@"C:\Users\fcermak\source\repos\BillionSort\BillionSort\BillionSort\Others\SampleData.txt");
            importTXT.LineByLine();
            
            Console.ReadLine();
        }
    }
}
