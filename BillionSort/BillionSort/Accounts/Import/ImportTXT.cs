using BillionSort.Logs;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace BillionSort.Accounts.Import
{
    public class ImportTXT
    {
        Log log = new Log();
        public List<String> Line = new List<string>();
        
        public string filePath { get; set; }
        public ImportTXT(string filePath)
        {
            this.filePath = filePath;
        }
        /// <summary>
        /// Přečte TXT řádek po řádku a přiřadí je do listu stringů 
        /// </summary>
        public void LineByLine()
        {
            string line;
            System.IO.StreamReader file =
            new System.IO.StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {            
             //   log.WriteLine(line);
                Line.Add(line);               
            }
            file.Close();
        }
        
    }
}
