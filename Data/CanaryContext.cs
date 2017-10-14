using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class CanaryContext : DbContext
    {
        public CanaryContext (DbContextOptions<CanaryContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication3.Models.Canary> Canary { get; set; }
    }
}
