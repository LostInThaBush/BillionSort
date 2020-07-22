using BillionSort.Logs;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;

namespace BillionSort.Accounts.Import
{
    public class ImportTXT
    {
        DbMethods dbMethods = new DbMethods("Accounts");
        Log log = new Log();
        public List<String> Line = new List<string>();
        public string filePath { get; set; }
        Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        public ImportTXT(string filePath)
        {
            log.WriteLine("Import data from TxT to DB started " + unixTimestamp.ToString());
            this.filePath = filePath;
            LineByLine();
           // ListToDb();
        }
        /// <summary>
        /// Přečte TXT řádek po řádku a přiřadí je do listu stringů 
        /// </summary>
        public void LineByLine()
        {
            int nullLines = 0;
            string line;
            System.IO.StreamReader file =
            new System.IO.StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {
                if (nullLines < 2)
                {
                    if (line != null)
                    {
                        string name = line.Substring(0, line.IndexOf('@'));
                        string email = line.Substring(0,line.IndexOf(':'));
                        string typeOfMail = line.Substring(line.IndexOf('@'), (line.IndexOf(':') - line.IndexOf('@')));
                        string password = line.Substring(line.IndexOf(':') + 1);
                        dbMethods.AddAccount(new Account { Email = email, Password = password, CustomData = typeOfMail, CustomData02 = name });
                    }
                    else
                    {
                        log.WriteLine("Null line");
                        nullLines++;
                    }

                }

            }
            file.Close();
            log.WriteLine("Import from file to DB complete");
        }
        /// <summary>
        /// Zapíše importované údaje do databáze
        /// </summary>
       /*
        *public void ListToDb()
        {

            DbMethods dbMethods = new DbMethods("Accounts");
            int nullLines = 0;
            for (int i=0; i <= Line.Count-1; i++)
            {               
                if(nullLines<2) { 
                if (Line[i] != null) { 
                string name = Line[i].Substring(0, Line[i].IndexOf('@'));
                string email = Line[i].Substring(0, Line[i].IndexOf(':'));
                string typeOfMail = Line[i].Substring(Line[i].IndexOf('@'), (Line[i].IndexOf(':')- Line[i].IndexOf('@')));
                string password = Line[i].Substring(Line[i].IndexOf(':')+1);
                dbMethods.AddAccount(new Account { Email = email, Password = password, CustomData = typeOfMail, CustomData02=name });
                } else
                    {
                        log.WriteLine("Null line:" + i.ToString());
                        nullLines++;
                    }
                    
                }


            }
            log.WriteLine(Line.Count.ToString() + " accaounts imported to DB");
        }
        */
        
    }
}
