using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CS174FINALPROJECTLITSCHER.Models
{
    public class SeedCartItem : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> entity)
        {
            entity.HasData(
                new CartItem { CartItemId =1,  CartId=1, CartItemDescription="this is what you bought", CartItemQuantity=1, CartItemUnitPrice=56.32 },
                new CartItem { CartItemId = 2, CartId=1, CartItemDescription = "this is antoher thing that you bought", CartItemQuantity = 1, CartItemUnitPrice = 56.32 }
                );
        }
    }
}
