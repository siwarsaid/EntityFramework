using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    internal class AccountContext : DbContext
    {

        public virtual DbSet<SavingAccount> Accounts { get; set; }
       
        public virtual DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LOCALHOST;Database=Bank;Integrated Security=false;security=false;User ID=sa;Password=Toto123*;");

        }

    }
}
