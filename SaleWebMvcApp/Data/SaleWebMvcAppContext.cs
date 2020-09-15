using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaleWebMvcApp.Models;

namespace SaleWebMvcApp.Data
{
    public class SaleWebMvcAppContext : DbContext
    {
        public SaleWebMvcAppContext (DbContextOptions<SaleWebMvcAppContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<SalesRecord> SaleRecord { get; set; }
        public DbSet<Seller> Seller { get; set; }
    }
}
