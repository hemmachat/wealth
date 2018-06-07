using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Wealth.Models
{
    public class Customer
    {
        [Required]
        public int CustomerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public decimal AccountBalance { get; set; }
        public string ContactInformation { get; set; }

        // this is a lazy way of mapping nested relationship with EF that might cause the model constraints to cry later
        public IEnumerable<Transaction> Transaction { get; set; }
    }
}