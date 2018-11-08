using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GHS.Models
{
    public class CheckPModel
    {
        [Key]
        public int TransactionId { get; set; }
        public double Amount { get; set; }
        public int CheckNumber { get; set; }
        public override string ToString()
        {
            return $"You paid ${Amount:0.00} with check number {CheckNumber}.";
        }
    }
}
