using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    internal class Person
    {
        public int Id { get; set; }
        public List<SavingAccount> Accounts { get; set; }
    }
}
