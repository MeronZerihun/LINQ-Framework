using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApp.Models
{
    [Table("Quote", Schema = "public")]
    public class Quote
    {
        public int QuoteId { get; set; }
        public String authorName { get; set; }
        public String body { get; set; }
        public DateTime entryDate { get; set; }

        public Quote()
        {
            entryDate = DateTime.UtcNow;
    
        }
    }
}
