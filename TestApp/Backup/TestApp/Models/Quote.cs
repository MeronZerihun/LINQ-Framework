using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApp.Models
{
    
    public class Quote
    {
        public int QuoteId { get; }
        public String authorName { get; set; }
        public String body { get; set; }
        public DateTime entryDate { get; set; }

        public Quote()
        {
            entryDate = DateTime.UtcNow;
    
        }
    }
}
