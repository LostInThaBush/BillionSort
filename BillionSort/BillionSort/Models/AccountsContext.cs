using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BillionSort.Models
{
    public class AccountsContext : DbContext
    {
        DbSet<Account> Accounts { get; set; }
        public AccountsContext(DbContextOptions<AccountsContext> options) : base(options)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AccountsContext>();
            optionsBuilder.UseSqlServer("Data Source=INLL9DL-LT\\MSSQLSERVER01;Initial Catalog=Accounts;Integrated Security=True");
            var context = new AccountsContext(optionsBuilder.Options);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source=INLL9DL-LT\\MSSQLSERVER01;Initial Catalog=Accounts;Integrated Security=True");
        //public async void
        
    }
    public class Account
    {
        [Key]
        public int AccountID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CustomData { get; set; }
        public string CustomData02 { get; set; }
        public string CustomData03 { get; set; }
        public string CustomData04 { get; set; }
        public string CustomData05 { get; set; }

    }


}
