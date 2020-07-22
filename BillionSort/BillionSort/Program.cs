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
            string fileName;
            for (int i=1; i < 111; i++)
            {
                fileName = i.ToString();
                ImportTXT importTXT = new ImportTXT(@"C:\Users\fcermak\Downloads\Exploit.in\" + fileName + ".txt");
            }
      
            
            Console.ReadLine();
        }
    }
}
