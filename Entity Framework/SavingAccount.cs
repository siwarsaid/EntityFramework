using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    internal class SavingAccount
    {
         public Guid Id { get; set; }
        public double InitialAmount {get; set;}
        public double Rate { get; set;}
        public bool IsMonthly { get; set;}
    }
}
