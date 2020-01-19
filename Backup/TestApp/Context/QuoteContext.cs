using System;
using System.Data.Entity;
using TestApp.Models;

namespace TestApp.Context
{
    public class QuoteContext: DbContext
    {
       public DbSet<Quote> Quotes;
        
    }
}
