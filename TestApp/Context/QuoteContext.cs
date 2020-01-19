using System;
using System.Data.Entity;
using TestApp.Models;

namespace TestApp.Context
{
    public class QuoteContext: DbContext
    {
        public QuoteContext() : base(nameOrConnectionString: "DefaultConnectionString") { }
        public DbSet<Quote> Quotes { get; set; }
        
    }
}
