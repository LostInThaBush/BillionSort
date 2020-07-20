using System;
using System.Collections.Generic;
using System.Text;

namespace BillionSort.Logs
{
   public class Buzzer
    {
        
        public static DateTime now = DateTime.Now;
        public static string stellarDate()
        {
            string sYear =now.Year.ToString();
            string sMonth = now.Month.ToString();
            string sDay = now.Day.ToString();
            return "Log_"+sYear+sMonth+sDay+".txt";
        }
    }
}
