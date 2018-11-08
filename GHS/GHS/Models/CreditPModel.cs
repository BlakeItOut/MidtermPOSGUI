using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GHS.Models
{
    public class CreditPModel
    {
        [Key]
        public int TransactionId { get; set; }
        public double Amount { get; set; }
        public string CardNumber { get; set; }
        public DateTime Expiration { get; set; }
        public string CVV { get; set; }
        public override string ToString()
        {
            return $"You paid ${Amount:0.00} with a credit card ending in {CardNumber.Substring(CardNumber.Length - 4)}";
        }
    }
}
