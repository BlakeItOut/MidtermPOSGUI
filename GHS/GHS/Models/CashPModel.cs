using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GHS.Models
{
    public class CashPModel
    {
        [Key]
        public int TransactionId { get; set; }
        public double Amount { get; set; }
        public double AmountTendered { get; set; }
        public double Change => AmountTendered - Amount;
        public override string ToString()
        {
            return $"You paid in cash with ${AmountTendered:0.00} and received ${Change:0.00} in change.";
        }
    }
}
