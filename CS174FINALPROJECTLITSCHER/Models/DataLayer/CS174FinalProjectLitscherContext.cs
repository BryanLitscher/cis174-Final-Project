using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

//using System;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;

namespace CS174FINALPROJECTLITSCHER.Models
{
    public class CS174FinalProjectLitscherContext : IdentityDbContext<User>
    {
        public CS174FinalProjectLitscherContext(DbContextOptions<CS174FinalProjectLitscherContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Appearance> Appearances { get; set; }
        public DbSet<Hardness> Hardnesses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { base.OnConfiguring(optionsBuilder); }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { 
            base.OnModelCreating(modelBuilder);
            // seed initial data
            modelBuilder.ApplyConfiguration(new SeedHardness());
            modelBuilder.ApplyConfiguration(new SeedAppearance());
            modelBuilder.ApplyConfiguration(new SeedProducts());
            modelBuilder.ApplyConfiguration(new SeedCartItem());
            modelBuilder.ApplyConfiguration(new SeedCart());
            modelBuilder.ApplyConfiguration(new SeedCartCustomer());
        }


    }
}
