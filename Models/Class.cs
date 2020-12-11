using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MonthlyBillsWebAPI.Models;

namespace CoreRestAPI.Models
{
    public class MonthlyBillsContext : DbContext
    {
        public MonthlyBillsContext(DbContextOptions<MonthlyBillsContext> options)
            : base(options)
        {

        }
        public DbSet<MonthlyBills> MonthlyBillz { get; set; }
    }
}
