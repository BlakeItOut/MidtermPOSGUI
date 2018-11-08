using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GHS.Models
{
    public class OrderModel
    {
        [Key]
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool CheckedOut { get; set; }
    }
}
