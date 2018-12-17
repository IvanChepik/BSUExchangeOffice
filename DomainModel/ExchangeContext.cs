using System;
using System.Data.Entity;
using DomainModel.Models;
namespace DomainModel
{
    public class ExchangeContext : DbContext                    // потом мейби не паблик sadfas
    {
        public ExchangeContext () : base ("ExchangeDb")
        {

        }

        public DbSet<Cashier> Cashiers { get; set; }

        public DbSet<Operation> Operations { get; set; }

        public DbSet<ExchangeRate> Rates { get; set; }

        public DbSet<DateRate> DateRates { get; set; }

        public DbSet<Person> Persons { get; set; }

    }
}
