using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class ParrotContext : DbContext
    {
        public ParrotContext (DbContextOptions<ParrotContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication3.Models.Parrot> Parrot { get; set; }
    }
}
