using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BillionSort.Accounts
{
    public class DbMethods
    {

        public AccountsContext accountsContext { get; set; }
        public string TableName { get; set; }
        public DbMethods(string TableName)
        {
            this.TableName = TableName;
            accountsContext = new AccountsContext();
        }
           
        public void AddAccount(string email, string password)
        {
            accountsContext.Add(new Account {Email = email, Password = password });
            accountsContext.SaveChanges();
        }
        public void RemoveAccount(string email, int? UID)
        {
            if (UID != null)
            {
                var uid = accountsContext.Accounts.OrderBy(x => x.AccountID).FirstOrDefault(y => y.AccountID == UID);
                accountsContext.Remove(uid);
            }
            else
            {
                var rEmail = accountsContext.Accounts.FirstOrDefault(y => y.Email == email);
                accountsContext.Remove(rEmail);
            }
            accountsContext.SaveChanges();
        }
        public void ClearTable()
        {

            accountsContext.Database.ExecuteSqlRaw("DELETE FROM Accounts");
            accountsContext.SaveChanges();
        }
        /// <summary>
        /// Enter SQL command as param. Example "INSERT INTO Accounts (Email, Password, CustomData) VALUES ('VeryWell@umpalumpa.com', 'SomeSorros', 'FirstCustom data')"
        /// </summary>
        /// <param name="command"></param>
        public void CustomSQLCommand(string command)
        {
            accountsContext.Database.ExecuteSqlRaw(command);
            accountsContext.SaveChanges();
        }
        
    }
}
