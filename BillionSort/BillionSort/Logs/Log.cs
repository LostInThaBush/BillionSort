using System;
using System.Collections.Generic;
using System.Text;

namespace BillionSort.Logs
{
  public  class Log
    {
        //C:\Users\fcermak\source\repos\BillionSort\BillionSort\BillionSort\Log
        //  C:\Users\fcermak\source\repos\BillionSort\BillionSort\BillionSort\Log\TestLog.txt
        
        string folderPath = @"C:\Users\fcermak\source\repos\BillionSort\BillionSort\BillionSort\Logs";

        public void CheckLog()
        {
            string filePath = System.IO.Path.Combine(folderPath, Buzzer.stellarDate());

            if (!System.IO.File.Exists(filePath))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(filePath))
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        fs.WriteByte(i);
                    }
                }
                Console.WriteLine("File created");
            }
            else
            {
                Console.WriteLine("Log file already exists.");
                return;
            }
        }
        public void WriteLine(string line)
        {
            string filePath = System.IO.Path.Combine(folderPath, Buzzer.stellarDate());
            CheckLog();
            using (System.IO.StreamWriter file =
           new System.IO.StreamWriter(filePath, true))
            {
                file.WriteLine(line);
            }

        }
    }
}
