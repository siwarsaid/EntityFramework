using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    internal class SavingCalculator
    {
        public double Taux {  get; set; }
        public double CalculTotalSaving(List<SavingAccount> accounts, int years)
        {
            double total = 0;
            foreach (SavingAccount account in accounts)
            {
                double amount= account.InitialAmount;
                if(account.IsMonthly)
                {
                    for (int i = 0; i < years * 12; i++)
                    {
                        amount += amount * (account.Rate / 100);
                    }
                }
                else
                    for (int i = 0; i < years; i++)
                    {
                        amount += amount * (account.Rate / 100);
                        total += amount;
                    }
                total += amount;
            }
            return total;
        }
    }
}
