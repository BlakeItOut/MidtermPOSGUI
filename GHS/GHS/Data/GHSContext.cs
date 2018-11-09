using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GHS.Models;

namespace GHS.Models
{
    public class GHSContext : DbContext
    {
        public GHSContext (DbContextOptions<GHSContext> options)
            : base(options)
        {
        }

        public DbSet<GHS.Models.ProductModel> ProductModel { get; set; }

        public DbSet<GHS.Models.ProductOrderModel> ProductOrderModel { get; set; }
    }
}
