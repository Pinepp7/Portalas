using Microsoft.EntityFrameworkCore;
using Portalas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portalas.Repositories
{
    public class MyDbContext : DbContext
    {
        public DbSet<Post> puslapis { get; set; }

        public DbSet<Vartotojas> vartotojas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=PostaPortal;Trusted_Connection=True;TrustServerCertificate=true;");
        }
    }

}
