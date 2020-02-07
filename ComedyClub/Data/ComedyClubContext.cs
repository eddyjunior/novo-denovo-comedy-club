using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ComedyClub.Models
{
    public class ComedyClubContext : DbContext
    {
        public ComedyClubContext (DbContextOptions<ComedyClubContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Seller> Seller { get; set; }
    }
}
