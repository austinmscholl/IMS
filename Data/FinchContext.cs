using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class FinchContext : DbContext
    {
        public FinchContext (DbContextOptions<FinchContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication3.Models.Finch> Finch { get; set; }
    }
}
