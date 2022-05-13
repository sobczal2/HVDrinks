using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sobczal1.HVDrinks.Domain.Cocktails;

namespace Sobczal1.HVDrinks.Persistence.Configuration.Entities;

public class CocktailImageConfiguration : IEntityTypeConfiguration<CocktailImage>
{
    public void Configure(EntityTypeBuilder<CocktailImage> builder)
    {
        builder
            .HasOne(p => p.Cocktail)
            .WithMany(p => p.CocktailImages)
            .HasForeignKey(p => p.CocktailId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .Property(p => p.Url)
            .IsRequired();

        builder
            .Property(p => p.Alt)
            .IsRequired();

        builder
            .Property(p => p.CocktailId)
            .IsRequired();

        builder
            .HasData(new List<CocktailImage>
            {
                new CocktailImage
                {
                    Id = new Guid("7B25695E-FF81-4E41-B8EC-7977559985B7"),
                    DateCreated = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    LastModifiedDate = DateTime.Now,
                    LastModifiedBy = "SYSTEM",
                    Url = "somerandomurl1",
                    Alt = "Stock image of a smart dishwasher",
                    Main = true,
                    CocktailId = new Guid("CDCF7AE2-A928-453E-8373-34ED6C1B9DDC")
                }
            });
    }
}