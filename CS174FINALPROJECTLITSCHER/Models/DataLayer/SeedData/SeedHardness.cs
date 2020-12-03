using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CS174FINALPROJECTLITSCHER.Models
{
    internal class SeedHardness : IEntityTypeConfiguration<Hardness>
    {
        public void Configure(EntityTypeBuilder<Hardness> entity)
        {
            entity.HasData(
                    new Hardness() { HardnessID = "all", Moisture = "All" },
                    new Hardness() { HardnessID = "soft", Moisture = "Soft" },
                    new Hardness() { HardnessID = "semsoft", Moisture = "Semi-soft" },
                    new Hardness() { HardnessID = "medhard", Moisture = "Medium-hard" },
                    new Hardness() { HardnessID = "hard", Moisture = "Semi-hard or hard" }
            );
        }
    }
}
