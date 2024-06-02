namespace Entity_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AccountContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var person = new Person
                {
                    Accounts = new List<SavingAccount>
                            {
                              new SavingAccount { Id = Guid.NewGuid(), InitialAmount = 2000000,Rate = 5, IsMonthly = true },
                              new SavingAccount { Id = Guid.NewGuid(), InitialAmount = 250000,Rate = 15, IsMonthly = false },
                               new SavingAccount { Id = Guid.NewGuid(), InitialAmount = 10000000, Rate = 2, IsMonthly = false }
                            }
                };
                context.Add(person);
                context.SaveChanges();
            }
        }
    }
}
