using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CS174FINALPROJECTLITSCHER.Models
{
    internal class SeedCart : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> entity)
        {
            entity.HasData(
                //new Cart { CartId = 1, CartCustomerId = 1, CartDateTime= DateTime.Now }
                new Cart { CartId = 1, CartCustomerId = 1 }
            );
        }
    }
}
