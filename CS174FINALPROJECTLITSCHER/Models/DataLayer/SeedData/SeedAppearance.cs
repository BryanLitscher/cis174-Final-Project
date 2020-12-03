using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CS174FINALPROJECTLITSCHER.Models
{
    internal class SeedAppearance : IEntityTypeConfiguration<Appearance>
    {
        public void Configure(EntityTypeBuilder<Appearance> entity)
        {
            entity.HasData(
                new Appearance() { AppearanceID = "all", Color = "All" },
                new Appearance() { AppearanceID = "white", Color = "White" },
                new Appearance() { AppearanceID = "orange", Color = "Orange" }
            );
        }
    }

}
