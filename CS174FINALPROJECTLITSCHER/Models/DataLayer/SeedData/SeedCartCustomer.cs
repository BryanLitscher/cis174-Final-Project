using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CS174FINALPROJECTLITSCHER.Models
{
    public class SeedCartCustomer : IEntityTypeConfiguration<CartCustomer>
    {
        public void Configure(EntityTypeBuilder<CartCustomer> entity)
        {
            entity.HasData(
                new CartCustomer { CartCustomerId = 1, CartEmail = "bclitscher@dmacc.edu", CartName = "Bryan Litscher" }
                
            );
        }
    }
}
